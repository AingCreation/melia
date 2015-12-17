﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Const
{
	/// <summary>
	/// Object property enum
	/// </summary>
	/// <remarks>
	/// History:
	/// i10622 (2015-10-22, iCBT2 pre-launch)
	/// - PC changed from a 4k to a 6k range.
	/// - Several additions/removals
	/// 
	/// i10671 (2015-10-26)
	/// i10690 (2015-10-28)
	///  - No changes
	/// 
	/// i10725 (2015-11-03)
	/// - New:
	///   - Account.ChatStopTime
	///   - Account.TradeStopTime
	///   
	/// i10749 (2015-11-04)
	/// i10789 (2015-11-0X)
	/// i10791 (2015-11-10)
	/// i10842 (2015-11-17)
	/// i10873 (2015-11-24)
	/// i10911 (2015-12-01)
	/// i10939 (2015-12-08)
	/// - No changes
	/// </remarks>
	public static class ObjectProperty
	{
		public static class Account
		{
			public const short MaxPVPGrade = 6299;
			public const short Medal = 6300;
			public const short SelectedBarrack = 6301;
			public const short GiftMedal = 6302;
			public const short Medal_Get_Date = 6303;
			public const short ReceiveGiftMedal = 6304;
			public const short ChatStopTime = 8476;
			public const short TradeStopTime = 8477;
			public const short TokenTime = 9048;
			public const short PremiumMedal = 10021;
		}

		public static class PC
		{
			public const short Name = 6862;
			public const short Size = 6863;
			public const short MonRank = 6864;
			public const short ChatStopTime = 6865;
			public const short DummyPCZoneID = 6866;
			public const short Permission = 6867;
			public const short Lv = 6868;
			public const short MaxHateCount_BM = 6869;
			public const short Job = 6870;
			public const short ClassType = 6871;
			public const short BeforeZoneInst = 6872;
			public const short Lock_PoseLevel = 6873;
			public const short RestartSavePoint = 6874;
			public const short GMOrder = 6875;
			public const short INT = 6876;
			public const short Gender = 6877;
			public const short NowWeight = 6878;
			public const short STR = 6879;
			public const short GroupName = 6880;
			public const short BonusExp_BM = 6881;
			public const short RaceType = 6882;
			public const short MissionPosY = 6883;
			public const short CON_STAT = 6884;
			public const short MNA_STAT = 6885;
			public const short RSPTIME = 6886;
			public const short DEX = 6887;
			public const short LearnAbilityID = 6888;
			public const short Scale = 6889;
			public const short MShield = 6890;
			public const short LearnAbilityTime = 6891;
			public const short MissionPosX = 6892;
			public const short MSPD = 6893;
			public const short FIXMSPD_BM = 6894;
			public const short STR_STAT = 6895;
			public const short BonusJobExp_BM = 6896;
			public const short MissionPosZ = 6897;
			public const short Jumpable = 6898;
			public const short INT_STAT = 6899;
			public const short MaxSta = 6900;
			public const short MaxWeight = 6901;
			public const short DEX_STAT = 6902;
			public const short LatestMaxExp = 6903;
			public const short CON = 6904;
			public const short RHPTIME = 6905;
			public const short MNA = 6906;
			public const short RefreshHP = 6907;
			public const short EquipingAchieve = 6908;
			public const short quickslotnexpbar = 6909;
			public const short PartyEnterTime = 6910;
			public const short Start_time = 6911;
			public const short MSKILL_Bonus = 6912;
			public const short Dark_Atk_BM = 6913;
			public const short CRTHR_FIXED = 6914;
			public const short HPDrain = 6915;
			public const short JumpPower = 6916;
			public const short skillvan = 6917;
			public const short Talk_NPC = 6918;
			public const short MAXRR_Bonus = 6919;
			public const short Paramune_Atk_BM = 6920;
			public const short HPDrain_BM = 6921;
			public const short JumpCount = 6922;
			public const short quest = 6923;
			public const short MAXDR_Bonus = 6924;
			public const short Velnias_Atk_BM = 6925;
			public const short SkillRange_BM = 6926;
			public const short CurAtkNo = 6927;
			public const short minimap = 6928;
			public const short DEX_Bonus = 6929;
			public const short Cloth_Atk_BM = 6930;
			public const short ForceVel_BM = 6931;
			public const short StunRate_BM = 6932;
			public const short RSP_BM = 6933;
			public const short MINPATK_BM = 6934;
			public const short changejobbutton = 6935;
			public const short Iron_Atk_BM = 6936;
			public const short LUCK_Bonus = 6937;
			public const short KDImmune = 6938;
			public const short MAXPATK_SUB = 6939;
			public const short DefAries_BM = 6940;
			public const short MHP_Bonus = 6941;
			public const short Ice_Atk_BM = 6942;
			public const short BOOST = 6943;
			public const short AddFever = 6944;
			public const short MINMATK_BM = 6945;
			public const short GQuestEncounter = 6946;
			public const short DefStrike_BM = 6947;
			public const short ATK_Bonus = 6948;
			public const short Earth_Atk_BM = 6949;
			public const short Const = 6950;
			public const short MAXMATK_BM = 6951;
			public const short targetbuff = 6952;
			public const short Chain_Atk = 6953;
			public const short Revive_BM = 6954;
			public const short INT_Bonus = 6955;
			public const short RSPTIME_BM = 6956;
			public const short SubJob = 6957;
			public const short sysmenu = 6958;
			public const short MAXHR_Bonus = 6959;
			public const short Forester_Atk_BM = 6960;
			public const short SkillAngle_BM = 6961;
			public const short FightMode = 6962;
			public const short targetinfo = 6963;
			public const short Leather_Atk_BM = 6964;
			public const short CON_Bonus = 6965;
			public const short SPRate = 6966;
			public const short MINPATK_SUB = 6967;
			public const short monsterbaseinfo = 6968;
			public const short Chain_Atk_BM = 6969;
			public const short HitCount_BM = 6970;
			public const short MNA_Bonus = 6971;
			public const short KDHit_BM = 6972;
			public const short MAXPATK_BM = 6973;
			public const short inventory = 6974;
			public const short MATK_Bonus = 6975;
			public const short Holy_Atk_BM = 6976;
			public const short ATK_ADD_BM = 6977;
			public const short Ghost_Atk_BM = 6978;
			public const short PlayTime = 6979;
			public const short RSta_BM = 6980;
			public const short map = 6981;
			public const short STR_Bonus = 6982;
			public const short Klaida_Atk_BM = 6983;
			public const short StunRate = 6984;
			public const short status = 6985;
			public const short Alliance = 6986;
			public const short MAXDEF_Bonus = 6987;
			public const short Widling_Atk_BM = 6988;
			public const short HPDrain_ADD = 6989;
			public const short DefSlash_BM = 6990;
			public const short MSP_Bonus = 6991;
			public const short Poison_Atk_BM = 6992;
			public const short ArmorMaterial = 6993;
			public const short Attribute = 6994;
			public const short BLK = 6995;
			public const short CAST = 6996;
			public const short Hair = 6997;
			public const short Face = 6998;
			public const short StatByBonus = 6999;
			public const short Sta_Jump = 7000;
			public const short GuildPoint_1 = 7001;
			public const short SkillPtsByLevel = 7002;
			public const short AbilitySlot = 7003;
			public const short HitDummy = 7004;
			public const short STR_ADD = 7005;
			public const short GP_Delay = 7006;
			public const short HairType = 7007;
			public const short SpecialDefType = 7008;
			public const short Fire_Atk_BM = 7009;
			public const short ForceVel = 7010;
			public const short DR_BM = 7011;
			public const short KdDead = 7012;
			public const short KDownVAngle = 7013;
			public const short BLK_BM = 7014;
			public const short ImmuneDebuff = 7015;
			public const short KDArmor = 7016;
			public const short HP = 7017;
			public const short DashRun = 7018;
			public const short ResEarth_BM = 7019;
			public const short ResEarth = 7020;
			public const short DEX_BM = 7021;
			public const short MHP_BM = 7022;
			public const short Holy_Atk = 7023;
			public const short DR = 7024;
			public const short Ghost_Atk = 7025;
			public const short ResDark = 7026;
			public const short CRTATK_BM = 7027;
			public const short SDR_BM = 7028;
			public const short Poison_Atk = 7029;
			public const short HR = 7030;
			public const short Velnias_Atk = 7031;
			public const short ResHoly = 7032;
			public const short CON_BM = 7033;
			public const short CRTDR_BM = 7034;
			public const short Ice_Atk = 7035;
			public const short SR = 7036;
			public const short Forester_Atk = 7037;
			public const short ResFire = 7038;
			public const short ResLightning_BM = 7039;
			public const short SR_BM = 7040;
			public const short CRTHR = 7041;
			public const short Leather_Atk = 7042;
			public const short DefSlash = 7043;
			public const short ResIce_BM = 7044;
			public const short CRTHR_BM = 7045;
			public const short DEF = 7046;
			public const short SkillPower = 7047;
			public const short ASPD = 7048;
			public const short MiddleSize_Atk = 7049;
			public const short ATK_BM = 7050;
			public const short SkillRange = 7051;
			public const short SP = 7052;
			public const short SmallSize_Atk = 7053;
			public const short MaxWeight_Bonus = 7054;
			public const short MaxSta_BM = 7055;
			public const short KDPow = 7056;
			public const short DEF_BM = 7057;
			public const short CRTDEF = 7058;
			public const short MSP = 7059;
			public const short MAXSTA_Bonus = 7060;
			public const short MDEF = 7061;
			public const short STR_BM = 7062;
			public const short Lightning_Atk = 7063;
			public const short RHP = 7064;
			public const short CRTATK = 7065;
			public const short MHP = 7066;
			public const short MHR = 7067;
			public const short MNA_BM = 7068;
			public const short SDR = 7069;
			public const short Earth_Atk = 7070;
			public const short MDEF_BM = 7071;
			public const short MSP_BM = 7072;
			public const short INT_BM = 7073;
			public const short Dark_Atk = 7074;
			public const short CRTDR = 7075;
			public const short Paramune_Atk = 7076;
			public const short ResLightning = 7077;
			public const short BLK_BREAK = 7078;
			public const short Fire_Atk = 7079;
			public const short Iron_Atk = 7080;
			public const short DefStrike = 7081;
			public const short ResPoison_BM = 7082;
			public const short RSP = 7083;
			public const short Widling_Atk = 7084;
			public const short ResIce = 7085;
			public const short ResHoly_BM = 7086;
			public const short HR_BM = 7087;
			public const short HitCount = 7088;
			public const short Cloth_Atk = 7089;
			public const short DefAries = 7090;
			public const short ResFire_BM = 7091;
			public const short ASPD_BM = 7092;
			public const short SkillAngle = 7093;
			public const short LargeSize_Atk = 7094;
			public const short MATK_BM = 7095;
			public const short Klaida_Atk = 7096;
			public const short ResPoison = 7097;
			public const short ResDark_BM = 7098;
			public const short Revive = 7099;
			public const short MergeClass1 = 7100;
			public const short MergeTable1 = 7101;
			public const short LODDist = 7102;
			public const short BtmOffset = 7103;
			public const short MidOffset = 7104;
			public const short TopOffset = 7105;
			public const short LookAtNode = 7106;
			public const short TopDummy = 7107;
			public const short RootNode = 7108;
			public const short MGP = 7109;
			public const short ImmuneBuff_BM = 7110;
			public const short KDownPower = 7111;
			public const short KP = 7112;
			public const short Mass = 7113;
			public const short HitDelayFix = 7114;
			public const short MonDmgRate = 7115;
			public const short BackHitRange = 7116;
			public const short LUCK = 7117;
			public const short JobName = 7118;
			public const short Sta_Runable = 7119;
			public const short ADD_Cooldown = 7120;
			public const short UsedStat = 7121;
			public const short AbilityPoint = 7122;
			public const short OpenSetGen = 7123;
			public const short MHR_BM = 7124;
			public const short BLK_BREAK_BM = 7125;
			public const short Sta_Recover = 7126;
			public const short REST_BM = 7127;
			public const short LUCK_STAT = 7128;
			public const short ClanID = 7129;
			public const short MSPD_BM = 7130;
			public const short BLKABLE = 7131;
			public const short Guardable = 7132;
			public const short LUCK_BM = 7133;
			public const short MNA_JOB = 7134;
			public const short GroupID = 7135;
			public const short PostDelay = 7136;
			public const short RapidFix_BM = 7137;
			public const short MGP_BM = 7138;
			public const short CRTDEF_BM = 7139;
			public const short StepAtk_Side = 7140;
			public const short LUCK_ADD = 7141;
			public const short INT_JOB = 7142;
			public const short Fame = 7143;
			public const short SizeRank = 7144;
			public const short KDPow_BM = 7145;
			public const short PATK_BM = 7146;
			public const short StepAtk_Front = 7147;
			public const short Murderer = 7148;
			public const short CreateParty = 7149;
			public const short MaxDefenced_BM = 7150;
			public const short KDArmorType = 7151;
			public const short MAXMATK = 7152;
			public const short Steppable = 7153;
			public const short MNA_ADD = 7154;
			public const short CON_JOB = 7155;
			public const short KDDefence_BM = 7156;
			public const short MINMATK = 7157;
			public const short Runnable = 7158;
			public const short Tutorial = 7159;
			public const short KDBonusDefence = 7160;
			public const short DEF_COMMON_BM = 7161;
			public const short MAXPATK = 7162;
			public const short MovingShotable = 7163;
			public const short INT_ADD = 7164;
			public const short DEX_JOB = 7165;
			public const short prvBuff = 7166;
			public const short KDBonus_BM = 7167;
			public const short ATK_COMMON_BM = 7168;
			public const short EXP = 7169;
			public const short MINPATK = 7170;
			public const short MovingShot_BM = 7171;
			public const short StatPoint = 7172;
			public const short KDBonusDamage = 7173;
			public const short SPEED_BM = 7174;
			public const short RHP_BM = 7175;
			public const short JumpingShot_BM = 7176;
			public const short UsedSkillPts = 7177;
			public const short OriginalDEADAni = 7178;
			public const short MaxR_BM = 7179;
			public const short DamReflect = 7180;
			public const short JumpingShot = 7181;
			public const short SPReduceHP = 7182;
			public const short BeforeJobLv = 7183;
			public const short Sta_RunStart = 7184;
			public const short SelfHitEffect = 7185;
			public const short DEX_ADD = 7186;
			public const short RHPTIME_BM = 7187;
			public const short Sta_Run = 7188;
			public const short StepAtk_Back = 7189;
			public const short PartyID = 7190;
			public const short ComboAble = 7191;
			public const short OverHeat_BM = 7192;
			public const short Sta_R_Delay = 7193;
			public const short ADD_OverHeat = 7194;
			public const short StatByLevel = 7195;
			public const short LUCK_JOB = 7196;
			public const short LeagueID = 7197;
			public const short SPD_BM = 7198;
			public const short MovingShot = 7199;
			public const short CON_ADD = 7200;
			public const short STR_JOB = 7201;
			public const short FaceType = 7202;
			public const short KnockDownHit = 7203;
			public const short BonusDmg_BM = 7204;
			public const short Sta_Step = 7205;
			public const short SkillPower_BM = 7206;
			public const short BeforeLv = 7207;
			public const short HitOffset = 7208;
			public const short LimitBuffCount = 7209;
			public const short GP_Recover = 7210;
			public const short LimitBuffCount_BM = 7211;
			public const short ImmuneKnockDown_BM = 7212;
			public const short LargeSize_Atk_BM = 7213;
			public const short MiddleSize_Atk_BM = 7214;
			public const short SmallSize_Atk_BM = 7215;
			public const short Lightning_Atk_BM = 7216;
			public const short ArmorMaterial_ID = 7217;
			public const short CategoryType = 7218;
			public const short MaxHateCount = 7219;
			public const short MSPD_Bonus = 7505;
			public const short LearnAbilityID5 = 9262;
			public const short LearnAbilityID3 = 9263;
			public const short LearnAbilityID1 = 9264;
			public const short LearnAbilityID4 = 9265;
			public const short LearnAbilityID2 = 9266;
			public const short LearnAbilityTime2 = 9267;
			public const short LearnAbilityTime3 = 9268;
			public const short LearnAbilityTime4 = 9269;
			public const short LearnAbilityTime1 = 9270;
			public const short LearnAbilityTime5 = 9271;
			public const short LearnAbilityTime_4 = 9275;
			public const short LearnAbilityTime_2 = 9276;
			public const short LearnAbilityTime_5 = 9277;
			public const short LearnAbilityID_2 = 9278;
			public const short LearnAbilityID_5 = 9279;
			public const short LearnAbilityTime_3 = 9280;
			public const short LearnAbilityTime_1 = 9281;
			public const short LearnAbilityID_4 = 9282;
			public const short LearnAbilityID_3 = 9283;
			public const short LearnAbilityID_1 = 9284;
		}
	}
}
