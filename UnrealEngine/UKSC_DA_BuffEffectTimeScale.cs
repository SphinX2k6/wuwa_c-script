using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D50 RID: 7504
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_BuffEffectTimeScale")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_DA_BuffEffectTimeScale : UKSC_DA_BuffEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CBD5 RID: 117717 RVA: 0x002A7B4A File Offset: 0x002A5D4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_BuffEffectTimeScale._ClassPtr;
		}

		// Token: 0x0601CBD6 RID: 117718 RVA: 0x002A7B58 File Offset: 0x002A5D58
		public UKSC_DA_BuffEffectTimeScale() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_BuffEffectTimeScale.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CBD7 RID: 117719 RVA: 0x002A7B80 File Offset: 0x002A5D80
		[NullableContext(1)]
		public UKSC_DA_BuffEffectTimeScale(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_BuffEffectTimeScale.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073A6 RID: 29606
		// (get) Token: 0x0601CBD8 RID: 117720 RVA: 0x002A7BB3 File Offset: 0x002A5DB3
		// (set) Token: 0x0601CBD9 RID: 117721 RVA: 0x002A7BC3 File Offset: 0x002A5DC3
		public unsafe float TimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectTimeScale.__PropertyOffset_TimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectTimeScale.__PropertyOffset_TimeScale) = value;
			}
		}

		// Token: 0x170073A7 RID: 29607
		// (get) Token: 0x0601CBDA RID: 117722 RVA: 0x002A7BD4 File Offset: 0x002A5DD4
		// (set) Token: 0x0601CBDB RID: 117723 RVA: 0x002A7BE4 File Offset: 0x002A5DE4
		public unsafe bool Revert
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectTimeScale.__PropertyOffset_Revert) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectTimeScale.__PropertyOffset_Revert) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601CBDC RID: 117724 RVA: 0x002A7BF5 File Offset: 0x002A5DF5
		static UKSC_DA_BuffEffectTimeScale()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_BuffEffectTimeScale");
		}

		// Token: 0x0601CBDD RID: 117725 RVA: 0x002A7C03 File Offset: 0x002A5E03
		protected UKSC_DA_BuffEffectTimeScale(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F954 RID: 63828
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_BuffEffectTimeScale";

		// Token: 0x0400F955 RID: 63829
		private static IntPtr _ClassPtr;

		// Token: 0x0400F956 RID: 63830
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F957 RID: 63831
		internal static int __PropertyOffset_TimeScale;

		// Token: 0x0400F958 RID: 63832
		internal static int __PropertyOffset_Revert;
	}
}
