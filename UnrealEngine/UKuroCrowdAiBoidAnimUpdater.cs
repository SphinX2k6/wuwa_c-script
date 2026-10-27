using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017EB RID: 6123
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiBoidAnimUpdater")]
	[UnrealStructLayout(624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class UKuroCrowdAiBoidAnimUpdater : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060169D5 RID: 92629 RVA: 0x0020FF4F File Offset: 0x0020E14F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCrowdAiBoidAnimUpdater._ClassPtr;
		}

		// Token: 0x060169D6 RID: 92630 RVA: 0x0020FF5C File Offset: 0x0020E15C
		public UKuroCrowdAiBoidAnimUpdater() : this(BuiltinUtils.AllocNativeUObject(UKuroCrowdAiBoidAnimUpdater.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060169D7 RID: 92631 RVA: 0x0020FF84 File Offset: 0x0020E184
		[NullableContext(1)]
		public UKuroCrowdAiBoidAnimUpdater(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCrowdAiBoidAnimUpdater.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060169D8 RID: 92632 RVA: 0x0020FFB7 File Offset: 0x0020E1B7
		public bool StopMontage(int AnimIndex, bool bImmediately = true)
		{
			return UKuroCrowdAiBoidAnimUpdater.__StopMontage_Internal(base.NativePtr, AnimIndex, bImmediately);
		}

		// Token: 0x060169D9 RID: 92633 RVA: 0x0020FFC6 File Offset: 0x0020E1C6
		public bool SetMontagePosition(int AnimIndex, float NewPosition)
		{
			return UKuroCrowdAiBoidAnimUpdater.__SetMontagePosition_Internal(base.NativePtr, AnimIndex, NewPosition);
		}

		// Token: 0x060169DA RID: 92634 RVA: 0x0020FFD5 File Offset: 0x0020E1D5
		public bool SetMontagePlayRate(int AnimIndex, float NewPlayRate)
		{
			return UKuroCrowdAiBoidAnimUpdater.__SetMontagePlayRate_Internal(base.NativePtr, AnimIndex, NewPlayRate);
		}

		// Token: 0x060169DB RID: 92635 RVA: 0x0020FFE4 File Offset: 0x0020E1E4
		public bool SetMontageNextSection(int AnimIndex, FName FromSection, FName ToSection)
		{
			return UKuroCrowdAiBoidAnimUpdater.__SetMontageNextSection_Internal(base.NativePtr, AnimIndex, FromSection, ToSection);
		}

		// Token: 0x060169DC RID: 92636 RVA: 0x0020FFF4 File Offset: 0x0020E1F4
		public bool PlayMontage(int AnimIndex, float PlayRate = 1f, float StartPos = 0f, bool bIsLoop = false)
		{
			return UKuroCrowdAiBoidAnimUpdater.__PlayMontage_Internal(base.NativePtr, AnimIndex, PlayRate, StartPos, bIsLoop);
		}

		// Token: 0x060169DD RID: 92637 RVA: 0x00210006 File Offset: 0x0020E206
		[NullableContext(1)]
		public FMontageSectionInfoItem GetMontageSectionInfo(int AnimIndex, FName SectionName)
		{
			return new FMontageSectionInfoItem(UKuroCrowdAiBoidAnimUpdater.__GetMontageSectionInfo_Internal(base.NativePtr, AnimIndex, SectionName), null);
		}

		// Token: 0x060169DE RID: 92638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StopMontage_Internal(IntPtr @this, int AnimIndex, bool bImmediately);

		// Token: 0x060169DF RID: 92639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetMontagePosition_Internal(IntPtr @this, int AnimIndex, float NewPosition);

		// Token: 0x060169E0 RID: 92640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetMontagePlayRate_Internal(IntPtr @this, int AnimIndex, float NewPlayRate);

		// Token: 0x060169E1 RID: 92641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetMontageNextSection_Internal(IntPtr @this, int AnimIndex, FName FromSection, FName ToSection);

		// Token: 0x060169E2 RID: 92642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PlayMontage_Internal(IntPtr @this, int AnimIndex, float PlayRate, float StartPos, bool bIsLoop);

		// Token: 0x060169E3 RID: 92643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMontageSectionInfo_Internal(IntPtr @this, int AnimIndex, FName SectionName);

		// Token: 0x060169E4 RID: 92644 RVA: 0x0021001B File Offset: 0x0020E21B
		static UKuroCrowdAiBoidAnimUpdater()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiBoidAnimUpdater");
		}

		// Token: 0x060169E5 RID: 92645 RVA: 0x00210029 File Offset: 0x0020E229
		protected UKuroCrowdAiBoidAnimUpdater(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C486 RID: 50310
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiBoidAnimUpdater";

		// Token: 0x0400C487 RID: 50311
		private static IntPtr _ClassPtr;

		// Token: 0x0400C488 RID: 50312
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
