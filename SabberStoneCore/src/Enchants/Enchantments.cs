﻿using System.Collections.Generic;
using SabberStoneCore.CardSets;
using SabberStoneCore.CardSets.Standard;

namespace SabberStoneCore.Enchants
{
	public interface ILazyRemove
	{
		void Remove();
	}

	internal class Enchantments
	{
		private static Enchantments _instance;

		/// <summary>
		/// Contains all defined enchantments.
		/// The index is the CARDID of the card which enchantments are defined.
		/// </summary>
		private readonly Dictionary<string, List<Enchantment>> _entchantmentDic;

		/// <summary>
		/// Private constructor as per Singleton pattern.
		/// </summary>
		private Enchantments()
		{
			_entchantmentDic =
			new Dictionary<string, List<Enchantment>>();

			// Standard
			CoreCardsGen.AddAll(_entchantmentDic);
			Expert1CardsGen.AddAll(_entchantmentDic);
			GangsCardsGen.AddAll(_entchantmentDic);
			KaraCardsGen.AddAll(_entchantmentDic);
			OgCardsGen.AddAll(_entchantmentDic);
			UngoroCardsGen.AddAll(_entchantmentDic);
			IcecrownCardsGen.AddAll(_entchantmentDic);

			// Rest
			HofCardsGen.AddAll(_entchantmentDic);
			NaxxCardsGen.AddAll(_entchantmentDic);
			GvgCardsGen.AddAll(_entchantmentDic);
			BrmCardsGen.AddAll(_entchantmentDic);
			TgtCardsGen.AddAll(_entchantmentDic);
			LoeCardsGen.AddAll(_entchantmentDic);
		}

		/// <summary>
		/// Use the Singleton pattern to provide the same enchantments to each requester.
		/// </summary>
		public static Enchantments Instance => _instance ?? (_instance = new Enchantments());

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public IReadOnlyDictionary<string, List<Enchantment>> Get => _entchantmentDic;
	}
}
