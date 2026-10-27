using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E28 RID: 7720
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SceneComp")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UKSC_SceneComp : UKSC_CompBase, IUnrealUObject, IUnrealObject, IKuroFastCollisionInterface_Shape, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601D6C5 RID: 120517 RVA: 0x002B7662 File Offset: 0x002B5862
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_SceneComp._ClassPtr;
		}

		// Token: 0x0601D6C6 RID: 120518 RVA: 0x002B766E File Offset: 0x002B586E
		int IKuroFastCollisionInterface_Shape.InterfaceOffset()
		{
			return UKSC_SceneComp.__InterfaceOffset_IKuroFastCollisionInterface_Shape;
		}

		// Token: 0x0601D6C7 RID: 120519 RVA: 0x002B7678 File Offset: 0x002B5878
		public UKSC_SceneComp() : this(BuiltinUtils.AllocNativeUObject(UKSC_SceneComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D6C8 RID: 120520 RVA: 0x002B76A0 File Offset: 0x002B58A0
		[NullableContext(1)]
		public UKSC_SceneComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_SceneComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700769B RID: 30363
		// (get) Token: 0x0601D6C9 RID: 120521 RVA: 0x002B76D3 File Offset: 0x002B58D3
		// (set) Token: 0x0601D6CA RID: 120522 RVA: 0x002B76E7 File Offset: 0x002B58E7
		[Nullable(2)]
		public unsafe UKSC_DA_SceneComp Da_SceneComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_SceneComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_SceneComp.__PropertyOffset_Da_SceneComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_SceneComp.__PropertyOffset_Da_SceneComp, value);
			}
		}

		// Token: 0x0601D6CB RID: 120523 RVA: 0x002B76FC File Offset: 0x002B58FC
		static UKSC_SceneComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_SceneComp");
		}

		// Token: 0x0601D6CC RID: 120524 RVA: 0x002B770A File Offset: 0x002B590A
		protected UKSC_SceneComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF49 RID: 65353
		internal static int __InterfaceOffset_IKuroFastCollisionInterface_Shape;

		// Token: 0x0400FF4A RID: 65354
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SceneComp";

		// Token: 0x0400FF4B RID: 65355
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF4C RID: 65356
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF4D RID: 65357
		internal static int __PropertyOffset_Da_SceneComp;
	}
}
