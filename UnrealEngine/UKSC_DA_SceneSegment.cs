using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DAA RID: 7594
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_SceneSegment")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_DA_SceneSegment : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D089 RID: 118921 RVA: 0x002AE8CE File Offset: 0x002ACACE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_SceneSegment._ClassPtr;
		}

		// Token: 0x0601D08A RID: 118922 RVA: 0x002AE8DC File Offset: 0x002ACADC
		public UKSC_DA_SceneSegment() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SceneSegment.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D08B RID: 118923 RVA: 0x002AE904 File Offset: 0x002ACB04
		[NullableContext(1)]
		public UKSC_DA_SceneSegment(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SceneSegment.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007521 RID: 29985
		// (get) Token: 0x0601D08C RID: 118924 RVA: 0x002AE937 File Offset: 0x002ACB37
		// (set) Token: 0x0601D08D RID: 118925 RVA: 0x002AE94B File Offset: 0x002ACB4B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AKSC_SceneSegment> RuntimeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneSegment.__PropertyOffset_RuntimeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneSegment.__PropertyOffset_RuntimeClass) = value;
			}
		}

		// Token: 0x17007522 RID: 29986
		// (get) Token: 0x0601D08E RID: 118926 RVA: 0x002AE960 File Offset: 0x002ACB60
		// (set) Token: 0x0601D08F RID: 118927 RVA: 0x002AE974 File Offset: 0x002ACB74
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AKSC_SceneSegment> SegmentActorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneSegment.__PropertyOffset_SegmentActorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneSegment.__PropertyOffset_SegmentActorClass) = value;
			}
		}

		// Token: 0x0601D090 RID: 118928 RVA: 0x002AE989 File Offset: 0x002ACB89
		static UKSC_DA_SceneSegment()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_SceneSegment");
		}

		// Token: 0x0601D091 RID: 118929 RVA: 0x002AE997 File Offset: 0x002ACB97
		protected UKSC_DA_SceneSegment(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC2B RID: 64555
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_SceneSegment";

		// Token: 0x0400FC2C RID: 64556
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC2D RID: 64557
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC2E RID: 64558
		internal static int __PropertyOffset_RuntimeClass;

		// Token: 0x0400FC2F RID: 64559
		internal static int __PropertyOffset_SegmentActorClass;
	}
}
