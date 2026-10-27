using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020B6 RID: 8374
	[UnrealObjectPath("/Script/LGUI.LGUIScaleAdaptation")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class ULGUIScaleAdaptation : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F8D5 RID: 129237 RVA: 0x002EE860 File Offset: 0x002ECA60
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIScaleAdaptation._ClassPtr;
		}

		// Token: 0x0601F8D6 RID: 129238 RVA: 0x002EE86C File Offset: 0x002ECA6C
		public ULGUIScaleAdaptation() : this(BuiltinUtils.AllocNativeUObject(ULGUIScaleAdaptation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F8D7 RID: 129239 RVA: 0x002EE894 File Offset: 0x002ECA94
		[NullableContext(1)]
		public ULGUIScaleAdaptation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIScaleAdaptation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C73 RID: 31859
		// (get) Token: 0x0601F8D8 RID: 129240 RVA: 0x002EE8C7 File Offset: 0x002ECAC7
		// (set) Token: 0x0601F8D9 RID: 129241 RVA: 0x002EE8D7 File Offset: 0x002ECAD7
		public unsafe float ScaleAdapatationPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIScaleAdaptation.__PropertyOffset_ScaleAdapatationPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIScaleAdaptation.__PropertyOffset_ScaleAdapatationPercent) = value;
			}
		}

		// Token: 0x17007C74 RID: 31860
		// (get) Token: 0x0601F8DA RID: 129242 RVA: 0x002EE8E8 File Offset: 0x002ECAE8
		// (set) Token: 0x0601F8DB RID: 129243 RVA: 0x002EE8F8 File Offset: 0x002ECAF8
		public unsafe float StartRadio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIScaleAdaptation.__PropertyOffset_StartRadio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIScaleAdaptation.__PropertyOffset_StartRadio) = value;
			}
		}

		// Token: 0x0601F8DC RID: 129244 RVA: 0x002EE909 File Offset: 0x002ECB09
		static ULGUIScaleAdaptation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIScaleAdaptation");
		}

		// Token: 0x0601F8DD RID: 129245 RVA: 0x002EE917 File Offset: 0x002ECB17
		protected ULGUIScaleAdaptation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401108A RID: 69770
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIScaleAdaptation";

		// Token: 0x0401108B RID: 69771
		private static IntPtr _ClassPtr;

		// Token: 0x0401108C RID: 69772
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401108D RID: 69773
		internal static int __PropertyOffset_ScaleAdapatationPercent;

		// Token: 0x0401108E RID: 69774
		internal static int __PropertyOffset_StartRadio;
	}
}
