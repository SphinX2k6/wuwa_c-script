using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200054D RID: 1357
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_AttrType")]
	public enum EKSC_AttrType : byte
	{
		// Token: 0x04003579 RID: 13689
		EAttributeType_None,
		// Token: 0x0400357A RID: 13690
		Lv,
		// Token: 0x0400357B RID: 13691
		LifeMax,
		// Token: 0x0400357C RID: 13692
		Life,
		// Token: 0x0400357D RID: 13693
		Shield,
		// Token: 0x0400357E RID: 13694
		Atk = 7,
		// Token: 0x0400357F RID: 13695
		Crit,
		// Token: 0x04003580 RID: 13696
		CritDamage,
		// Token: 0x04003581 RID: 13697
		Def,
		// Token: 0x04003582 RID: 13698
		AtkChange,
		// Token: 0x04003583 RID: 13699
		MaxLifeShieldChange,
		// Token: 0x04003584 RID: 13700
		BaseLife,
		// Token: 0x04003585 RID: 13701
		CritChange,
		// Token: 0x04003586 RID: 13702
		DamageChange,
		// Token: 0x04003587 RID: 13703
		DamageReduce,
		// Token: 0x04003588 RID: 13704
		DamageLifeSteal,
		// Token: 0x04003589 RID: 13705
		HealBase,
		// Token: 0x0400358A RID: 13706
		DamageReduceCollision,
		// Token: 0x0400358B RID: 13707
		DamageAbsorptionCount,
		// Token: 0x0400358C RID: 13708
		DamageChangePhys,
		// Token: 0x0400358D RID: 13709
		DamageChangeElement1,
		// Token: 0x0400358E RID: 13710
		DamageChangeElement2,
		// Token: 0x0400358F RID: 13711
		DamageChangeElement3,
		// Token: 0x04003590 RID: 13712
		DamageChangeElement4,
		// Token: 0x04003591 RID: 13713
		DamageChangeElement5,
		// Token: 0x04003592 RID: 13714
		DamageChangeElement6,
		// Token: 0x04003593 RID: 13715
		DamageResistancePhys,
		// Token: 0x04003594 RID: 13716
		DamageResistanceElement1,
		// Token: 0x04003595 RID: 13717
		DamageResistanceElement2,
		// Token: 0x04003596 RID: 13718
		DamageResistanceElement3,
		// Token: 0x04003597 RID: 13719
		DamageResistanceElement4,
		// Token: 0x04003598 RID: 13720
		DamageResistanceElement5,
		// Token: 0x04003599 RID: 13721
		DamageResistanceElement6,
		// Token: 0x0400359A RID: 13722
		HealChange,
		// Token: 0x0400359B RID: 13723
		HealedChange,
		// Token: 0x0400359C RID: 13724
		DamageReducePhys,
		// Token: 0x0400359D RID: 13725
		DamageReduceElement1,
		// Token: 0x0400359E RID: 13726
		DamageReduceElement2,
		// Token: 0x0400359F RID: 13727
		DamageReduceElement3,
		// Token: 0x040035A0 RID: 13728
		DamageReduceElement4,
		// Token: 0x040035A1 RID: 13729
		DamageReduceElement5,
		// Token: 0x040035A2 RID: 13730
		DamageReduceElement6,
		// Token: 0x040035A3 RID: 13731
		DamageAmplify1,
		// Token: 0x040035A4 RID: 13732
		DamageAmplify2,
		// Token: 0x040035A5 RID: 13733
		ShieldMax = 50,
		// Token: 0x040035A6 RID: 13734
		ShieldChange,
		// Token: 0x040035A7 RID: 13735
		LifeChange,
		// Token: 0x040035A8 RID: 13736
		DefChange,
		// Token: 0x040035A9 RID: 13737
		AtkExtra,
		// Token: 0x040035AA RID: 13738
		DefExtra,
		// Token: 0x040035AB RID: 13739
		LifeExtra,
		// Token: 0x040035AC RID: 13740
		SpecialEnergy1 = 70,
		// Token: 0x040035AD RID: 13741
		SpecialEnergy1Max,
		// Token: 0x040035AE RID: 13742
		SpecialEnergy1RecoverSpeed,
		// Token: 0x040035AF RID: 13743
		SpecialEnergy1ConsumeSpeed,
		// Token: 0x040035B0 RID: 13744
		SpecialEnergy1ChargeEfficiency,
		// Token: 0x040035B1 RID: 13745
		SpecialEnergy2,
		// Token: 0x040035B2 RID: 13746
		SpecialEnergy2Max,
		// Token: 0x040035B3 RID: 13747
		SpecialEnergy2RecoverSpeed,
		// Token: 0x040035B4 RID: 13748
		SpecialEnergy2ConsumeSpeed,
		// Token: 0x040035B5 RID: 13749
		SpecialEnergy2ChargeEfficiency,
		// Token: 0x040035B6 RID: 13750
		SpecialEnergy3,
		// Token: 0x040035B7 RID: 13751
		SpecialEnergy3Max,
		// Token: 0x040035B8 RID: 13752
		SpecialEnergy3RecoverSpeed,
		// Token: 0x040035B9 RID: 13753
		SpecialEnergy3ConsumeSpeed,
		// Token: 0x040035BA RID: 13754
		SpecialEnergy3ChargeEfficiency,
		// Token: 0x040035BB RID: 13755
		IgnoreDefRate = 99,
		// Token: 0x040035BC RID: 13756
		IgnoreDamageResistancePhys,
		// Token: 0x040035BD RID: 13757
		IgnoreDamageResistanceElement1,
		// Token: 0x040035BE RID: 13758
		IgnoreDamageResistanceElement2,
		// Token: 0x040035BF RID: 13759
		IgnoreDamageResistanceElement3,
		// Token: 0x040035C0 RID: 13760
		IgnoreDamageResistanceElement4,
		// Token: 0x040035C1 RID: 13761
		IgnoreDamageResistanceElement5,
		// Token: 0x040035C2 RID: 13762
		IgnoreDamageResistanceElement6,
		// Token: 0x040035C3 RID: 13763
		SkillCoolDown = 117,
		// Token: 0x040035C4 RID: 13764
		SkillCoolDownChange,
		// Token: 0x040035C5 RID: 13765
		SkillCoolDownChangeMin,
		// Token: 0x040035C6 RID: 13766
		Custom120,
		// Token: 0x040035C7 RID: 13767
		Custom121,
		// Token: 0x040035C8 RID: 13768
		Custom122,
		// Token: 0x040035C9 RID: 13769
		Custom123,
		// Token: 0x040035CA RID: 13770
		Custom124,
		// Token: 0x040035CB RID: 13771
		Custom125,
		// Token: 0x040035CC RID: 13772
		Custom126,
		// Token: 0x040035CD RID: 13773
		Custom127,
		// Token: 0x040035CE RID: 13774
		Custom128,
		// Token: 0x040035CF RID: 13775
		Custom129,
		// Token: 0x040035D0 RID: 13776
		Custom130,
		// Token: 0x040035D1 RID: 13777
		Custom131,
		// Token: 0x040035D2 RID: 13778
		Custom132,
		// Token: 0x040035D3 RID: 13779
		Custom133,
		// Token: 0x040035D4 RID: 13780
		Custom134,
		// Token: 0x040035D5 RID: 13781
		Custom135,
		// Token: 0x040035D6 RID: 13782
		Custom136,
		// Token: 0x040035D7 RID: 13783
		Custom137,
		// Token: 0x040035D8 RID: 13784
		Custom138,
		// Token: 0x040035D9 RID: 13785
		Custom139,
		// Token: 0x040035DA RID: 13786
		Custom140,
		// Token: 0x040035DB RID: 13787
		Custom141,
		// Token: 0x040035DC RID: 13788
		Custom142,
		// Token: 0x040035DD RID: 13789
		Custom143,
		// Token: 0x040035DE RID: 13790
		Custom144,
		// Token: 0x040035DF RID: 13791
		Custom145,
		// Token: 0x040035E0 RID: 13792
		Custom146,
		// Token: 0x040035E1 RID: 13793
		Custom147,
		// Token: 0x040035E2 RID: 13794
		Custom148,
		// Token: 0x040035E3 RID: 13795
		Custom149,
		// Token: 0x040035E4 RID: 13796
		Custom150,
		// Token: 0x040035E5 RID: 13797
		Custom151,
		// Token: 0x040035E6 RID: 13798
		Custom152,
		// Token: 0x040035E7 RID: 13799
		Custom153,
		// Token: 0x040035E8 RID: 13800
		Custom154,
		// Token: 0x040035E9 RID: 13801
		Custom155,
		// Token: 0x040035EA RID: 13802
		Custom156,
		// Token: 0x040035EB RID: 13803
		Custom157,
		// Token: 0x040035EC RID: 13804
		Custom158,
		// Token: 0x040035ED RID: 13805
		Custom159,
		// Token: 0x040035EE RID: 13806
		Custom160,
		// Token: 0x040035EF RID: 13807
		Custom161,
		// Token: 0x040035F0 RID: 13808
		Custom162,
		// Token: 0x040035F1 RID: 13809
		Custom163,
		// Token: 0x040035F2 RID: 13810
		Custom164,
		// Token: 0x040035F3 RID: 13811
		Custom165,
		// Token: 0x040035F4 RID: 13812
		Custom166,
		// Token: 0x040035F5 RID: 13813
		Custom167,
		// Token: 0x040035F6 RID: 13814
		Custom168,
		// Token: 0x040035F7 RID: 13815
		Custom169,
		// Token: 0x040035F8 RID: 13816
		Custom170,
		// Token: 0x040035F9 RID: 13817
		Custom171,
		// Token: 0x040035FA RID: 13818
		Custom172,
		// Token: 0x040035FB RID: 13819
		Custom173,
		// Token: 0x040035FC RID: 13820
		Custom174,
		// Token: 0x040035FD RID: 13821
		Custom175,
		// Token: 0x040035FE RID: 13822
		Custom176,
		// Token: 0x040035FF RID: 13823
		Custom177,
		// Token: 0x04003600 RID: 13824
		Custom178,
		// Token: 0x04003601 RID: 13825
		Custom179,
		// Token: 0x04003602 RID: 13826
		Custom180,
		// Token: 0x04003603 RID: 13827
		Custom181,
		// Token: 0x04003604 RID: 13828
		Custom182,
		// Token: 0x04003605 RID: 13829
		Custom183,
		// Token: 0x04003606 RID: 13830
		Custom184,
		// Token: 0x04003607 RID: 13831
		Custom185,
		// Token: 0x04003608 RID: 13832
		Custom186,
		// Token: 0x04003609 RID: 13833
		Custom187,
		// Token: 0x0400360A RID: 13834
		Custom188,
		// Token: 0x0400360B RID: 13835
		Custom189,
		// Token: 0x0400360C RID: 13836
		MoveSpeed,
		// Token: 0x0400360D RID: 13837
		MoveSpeedAdd,
		// Token: 0x0400360E RID: 13838
		MoveSpeedReduce,
		// Token: 0x0400360F RID: 13839
		AddBuffDuration = 199,
		// Token: 0x04003610 RID: 13840
		BuffDuration,
		// Token: 0x04003611 RID: 13841
		SpecialDamageChange1,
		// Token: 0x04003612 RID: 13842
		SpecialDamageChange2,
		// Token: 0x04003613 RID: 13843
		SpecialDamageChange3,
		// Token: 0x04003614 RID: 13844
		SpecialDamageChange4,
		// Token: 0x04003615 RID: 13845
		SpecialDamageChange5,
		// Token: 0x04003616 RID: 13846
		SpecialDamageChange6,
		// Token: 0x04003617 RID: 13847
		SpecialDamageChange7,
		// Token: 0x04003618 RID: 13848
		SpecialChange0 = 210,
		// Token: 0x04003619 RID: 13849
		SpecialChange1,
		// Token: 0x0400361A RID: 13850
		SpecialChange2,
		// Token: 0x0400361B RID: 13851
		SpecialChange3,
		// Token: 0x0400361C RID: 13852
		SpecialChange4,
		// Token: 0x0400361D RID: 13853
		SpecialChange5,
		// Token: 0x0400361E RID: 13854
		SpecialChange6,
		// Token: 0x0400361F RID: 13855
		SpecialChange7,
		// Token: 0x04003620 RID: 13856
		SpecialChange8,
		// Token: 0x04003621 RID: 13857
		SpecialChange9,
		// Token: 0x04003622 RID: 13858
		AttackSpeed,
		// Token: 0x04003623 RID: 13859
		AttackSpeedChange,
		// Token: 0x04003624 RID: 13860
		AccumulatedDamage = 225,
		// Token: 0x04003625 RID: 13861
		SpecialDamageReduce1 = 230,
		// Token: 0x04003626 RID: 13862
		SpecialDamageReduce2,
		// Token: 0x04003627 RID: 13863
		SpecialDamageReduce3,
		// Token: 0x04003628 RID: 13864
		SpecialDamageReduce4,
		// Token: 0x04003629 RID: 13865
		SpecialDamageReduce5,
		// Token: 0x0400362A RID: 13866
		AttributeType_Max = 255
	}
}
