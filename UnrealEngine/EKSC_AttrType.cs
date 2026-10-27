using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CB8 RID: 7352
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_AttrType")]
	public enum EKSC_AttrType : byte
	{
		// Token: 0x0400F521 RID: 62753
		EAttributeType_None,
		// Token: 0x0400F522 RID: 62754
		Lv,
		// Token: 0x0400F523 RID: 62755
		LifeMax,
		// Token: 0x0400F524 RID: 62756
		Life,
		// Token: 0x0400F525 RID: 62757
		Shield,
		// Token: 0x0400F526 RID: 62758
		Atk = 7,
		// Token: 0x0400F527 RID: 62759
		Crit,
		// Token: 0x0400F528 RID: 62760
		CritDamage,
		// Token: 0x0400F529 RID: 62761
		Def,
		// Token: 0x0400F52A RID: 62762
		AtkChange,
		// Token: 0x0400F52B RID: 62763
		MaxLifeShieldChange,
		// Token: 0x0400F52C RID: 62764
		BaseLife,
		// Token: 0x0400F52D RID: 62765
		CritChange,
		// Token: 0x0400F52E RID: 62766
		DamageChange,
		// Token: 0x0400F52F RID: 62767
		DamageReduce,
		// Token: 0x0400F530 RID: 62768
		DamageLifeSteal,
		// Token: 0x0400F531 RID: 62769
		HealBase,
		// Token: 0x0400F532 RID: 62770
		DamageReduceCollision,
		// Token: 0x0400F533 RID: 62771
		DamageAbsorptionCount,
		// Token: 0x0400F534 RID: 62772
		DamageChangePhys,
		// Token: 0x0400F535 RID: 62773
		DamageChangeElement1,
		// Token: 0x0400F536 RID: 62774
		DamageChangeElement2,
		// Token: 0x0400F537 RID: 62775
		DamageChangeElement3,
		// Token: 0x0400F538 RID: 62776
		DamageChangeElement4,
		// Token: 0x0400F539 RID: 62777
		DamageChangeElement5,
		// Token: 0x0400F53A RID: 62778
		DamageChangeElement6,
		// Token: 0x0400F53B RID: 62779
		DamageResistancePhys,
		// Token: 0x0400F53C RID: 62780
		DamageResistanceElement1,
		// Token: 0x0400F53D RID: 62781
		DamageResistanceElement2,
		// Token: 0x0400F53E RID: 62782
		DamageResistanceElement3,
		// Token: 0x0400F53F RID: 62783
		DamageResistanceElement4,
		// Token: 0x0400F540 RID: 62784
		DamageResistanceElement5,
		// Token: 0x0400F541 RID: 62785
		DamageResistanceElement6,
		// Token: 0x0400F542 RID: 62786
		HealChange,
		// Token: 0x0400F543 RID: 62787
		HealedChange,
		// Token: 0x0400F544 RID: 62788
		DamageReducePhys,
		// Token: 0x0400F545 RID: 62789
		DamageReduceElement1,
		// Token: 0x0400F546 RID: 62790
		DamageReduceElement2,
		// Token: 0x0400F547 RID: 62791
		DamageReduceElement3,
		// Token: 0x0400F548 RID: 62792
		DamageReduceElement4,
		// Token: 0x0400F549 RID: 62793
		DamageReduceElement5,
		// Token: 0x0400F54A RID: 62794
		DamageReduceElement6,
		// Token: 0x0400F54B RID: 62795
		DamageAmplify1,
		// Token: 0x0400F54C RID: 62796
		DamageAmplify2,
		// Token: 0x0400F54D RID: 62797
		ShieldMax = 50,
		// Token: 0x0400F54E RID: 62798
		ShieldChange,
		// Token: 0x0400F54F RID: 62799
		LifeChange,
		// Token: 0x0400F550 RID: 62800
		DefChange,
		// Token: 0x0400F551 RID: 62801
		AtkExtra,
		// Token: 0x0400F552 RID: 62802
		DefExtra,
		// Token: 0x0400F553 RID: 62803
		LifeExtra,
		// Token: 0x0400F554 RID: 62804
		SpecialEnergy1 = 70,
		// Token: 0x0400F555 RID: 62805
		SpecialEnergy1Max,
		// Token: 0x0400F556 RID: 62806
		SpecialEnergy1RecoverSpeed,
		// Token: 0x0400F557 RID: 62807
		SpecialEnergy1ConsumeSpeed,
		// Token: 0x0400F558 RID: 62808
		SpecialEnergy1ChargeEfficiency,
		// Token: 0x0400F559 RID: 62809
		SpecialEnergy2,
		// Token: 0x0400F55A RID: 62810
		SpecialEnergy2Max,
		// Token: 0x0400F55B RID: 62811
		SpecialEnergy2RecoverSpeed,
		// Token: 0x0400F55C RID: 62812
		SpecialEnergy2ConsumeSpeed,
		// Token: 0x0400F55D RID: 62813
		SpecialEnergy2ChargeEfficiency,
		// Token: 0x0400F55E RID: 62814
		SpecialEnergy3,
		// Token: 0x0400F55F RID: 62815
		SpecialEnergy3Max,
		// Token: 0x0400F560 RID: 62816
		SpecialEnergy3RecoverSpeed,
		// Token: 0x0400F561 RID: 62817
		SpecialEnergy3ConsumeSpeed,
		// Token: 0x0400F562 RID: 62818
		SpecialEnergy3ChargeEfficiency,
		// Token: 0x0400F563 RID: 62819
		IgnoreDefRate = 99,
		// Token: 0x0400F564 RID: 62820
		IgnoreDamageResistancePhys,
		// Token: 0x0400F565 RID: 62821
		IgnoreDamageResistanceElement1,
		// Token: 0x0400F566 RID: 62822
		IgnoreDamageResistanceElement2,
		// Token: 0x0400F567 RID: 62823
		IgnoreDamageResistanceElement3,
		// Token: 0x0400F568 RID: 62824
		IgnoreDamageResistanceElement4,
		// Token: 0x0400F569 RID: 62825
		IgnoreDamageResistanceElement5,
		// Token: 0x0400F56A RID: 62826
		IgnoreDamageResistanceElement6,
		// Token: 0x0400F56B RID: 62827
		SkillCoolDown = 117,
		// Token: 0x0400F56C RID: 62828
		SkillCoolDownChange,
		// Token: 0x0400F56D RID: 62829
		SkillCoolDownChangeMin,
		// Token: 0x0400F56E RID: 62830
		Custom120,
		// Token: 0x0400F56F RID: 62831
		Custom121,
		// Token: 0x0400F570 RID: 62832
		Custom122,
		// Token: 0x0400F571 RID: 62833
		Custom123,
		// Token: 0x0400F572 RID: 62834
		Custom124,
		// Token: 0x0400F573 RID: 62835
		Custom125,
		// Token: 0x0400F574 RID: 62836
		Custom126,
		// Token: 0x0400F575 RID: 62837
		Custom127,
		// Token: 0x0400F576 RID: 62838
		Custom128,
		// Token: 0x0400F577 RID: 62839
		Custom129,
		// Token: 0x0400F578 RID: 62840
		Custom130,
		// Token: 0x0400F579 RID: 62841
		Custom131,
		// Token: 0x0400F57A RID: 62842
		Custom132,
		// Token: 0x0400F57B RID: 62843
		Custom133,
		// Token: 0x0400F57C RID: 62844
		Custom134,
		// Token: 0x0400F57D RID: 62845
		Custom135,
		// Token: 0x0400F57E RID: 62846
		Custom136,
		// Token: 0x0400F57F RID: 62847
		Custom137,
		// Token: 0x0400F580 RID: 62848
		Custom138,
		// Token: 0x0400F581 RID: 62849
		Custom139,
		// Token: 0x0400F582 RID: 62850
		Custom140,
		// Token: 0x0400F583 RID: 62851
		Custom141,
		// Token: 0x0400F584 RID: 62852
		Custom142,
		// Token: 0x0400F585 RID: 62853
		Custom143,
		// Token: 0x0400F586 RID: 62854
		Custom144,
		// Token: 0x0400F587 RID: 62855
		Custom145,
		// Token: 0x0400F588 RID: 62856
		Custom146,
		// Token: 0x0400F589 RID: 62857
		Custom147,
		// Token: 0x0400F58A RID: 62858
		Custom148,
		// Token: 0x0400F58B RID: 62859
		Custom149,
		// Token: 0x0400F58C RID: 62860
		Custom150,
		// Token: 0x0400F58D RID: 62861
		Custom151,
		// Token: 0x0400F58E RID: 62862
		Custom152,
		// Token: 0x0400F58F RID: 62863
		Custom153,
		// Token: 0x0400F590 RID: 62864
		Custom154,
		// Token: 0x0400F591 RID: 62865
		Custom155,
		// Token: 0x0400F592 RID: 62866
		Custom156,
		// Token: 0x0400F593 RID: 62867
		Custom157,
		// Token: 0x0400F594 RID: 62868
		Custom158,
		// Token: 0x0400F595 RID: 62869
		Custom159,
		// Token: 0x0400F596 RID: 62870
		Custom160,
		// Token: 0x0400F597 RID: 62871
		Custom161,
		// Token: 0x0400F598 RID: 62872
		Custom162,
		// Token: 0x0400F599 RID: 62873
		Custom163,
		// Token: 0x0400F59A RID: 62874
		Custom164,
		// Token: 0x0400F59B RID: 62875
		Custom165,
		// Token: 0x0400F59C RID: 62876
		Custom166,
		// Token: 0x0400F59D RID: 62877
		Custom167,
		// Token: 0x0400F59E RID: 62878
		Custom168,
		// Token: 0x0400F59F RID: 62879
		Custom169,
		// Token: 0x0400F5A0 RID: 62880
		Custom170,
		// Token: 0x0400F5A1 RID: 62881
		Custom171,
		// Token: 0x0400F5A2 RID: 62882
		Custom172,
		// Token: 0x0400F5A3 RID: 62883
		Custom173,
		// Token: 0x0400F5A4 RID: 62884
		Custom174,
		// Token: 0x0400F5A5 RID: 62885
		Custom175,
		// Token: 0x0400F5A6 RID: 62886
		Custom176,
		// Token: 0x0400F5A7 RID: 62887
		Custom177,
		// Token: 0x0400F5A8 RID: 62888
		Custom178,
		// Token: 0x0400F5A9 RID: 62889
		Custom179,
		// Token: 0x0400F5AA RID: 62890
		Custom180,
		// Token: 0x0400F5AB RID: 62891
		Custom181,
		// Token: 0x0400F5AC RID: 62892
		Custom182,
		// Token: 0x0400F5AD RID: 62893
		Custom183,
		// Token: 0x0400F5AE RID: 62894
		Custom184,
		// Token: 0x0400F5AF RID: 62895
		Custom185,
		// Token: 0x0400F5B0 RID: 62896
		Custom186,
		// Token: 0x0400F5B1 RID: 62897
		Custom187,
		// Token: 0x0400F5B2 RID: 62898
		Custom188,
		// Token: 0x0400F5B3 RID: 62899
		Custom189,
		// Token: 0x0400F5B4 RID: 62900
		MoveSpeed,
		// Token: 0x0400F5B5 RID: 62901
		MoveSpeedAdd,
		// Token: 0x0400F5B6 RID: 62902
		MoveSpeedReduce,
		// Token: 0x0400F5B7 RID: 62903
		AddBuffDuration = 199,
		// Token: 0x0400F5B8 RID: 62904
		BuffDuration,
		// Token: 0x0400F5B9 RID: 62905
		SpecialDamageChange1,
		// Token: 0x0400F5BA RID: 62906
		SpecialDamageChange2,
		// Token: 0x0400F5BB RID: 62907
		SpecialDamageChange3,
		// Token: 0x0400F5BC RID: 62908
		SpecialDamageChange4,
		// Token: 0x0400F5BD RID: 62909
		SpecialDamageChange5,
		// Token: 0x0400F5BE RID: 62910
		SpecialDamageChange6,
		// Token: 0x0400F5BF RID: 62911
		SpecialDamageChange7,
		// Token: 0x0400F5C0 RID: 62912
		SpecialChange0 = 210,
		// Token: 0x0400F5C1 RID: 62913
		SpecialChange1,
		// Token: 0x0400F5C2 RID: 62914
		SpecialChange2,
		// Token: 0x0400F5C3 RID: 62915
		SpecialChange3,
		// Token: 0x0400F5C4 RID: 62916
		SpecialChange4,
		// Token: 0x0400F5C5 RID: 62917
		SpecialChange5,
		// Token: 0x0400F5C6 RID: 62918
		SpecialChange6,
		// Token: 0x0400F5C7 RID: 62919
		SpecialChange7,
		// Token: 0x0400F5C8 RID: 62920
		SpecialChange8,
		// Token: 0x0400F5C9 RID: 62921
		SpecialChange9,
		// Token: 0x0400F5CA RID: 62922
		AttackSpeed,
		// Token: 0x0400F5CB RID: 62923
		AttackSpeedChange,
		// Token: 0x0400F5CC RID: 62924
		AccumulatedDamage = 225,
		// Token: 0x0400F5CD RID: 62925
		SpecialDamageReduce1 = 230,
		// Token: 0x0400F5CE RID: 62926
		SpecialDamageReduce2,
		// Token: 0x0400F5CF RID: 62927
		SpecialDamageReduce3,
		// Token: 0x0400F5D0 RID: 62928
		SpecialDamageReduce4,
		// Token: 0x0400F5D1 RID: 62929
		SpecialDamageReduce5,
		// Token: 0x0400F5D2 RID: 62930
		AttributeType_Max = 255
	}
}
