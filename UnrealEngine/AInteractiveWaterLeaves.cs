using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AA2 RID: 6818
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.InteractiveWaterLeaves")]
	[UnrealStructLayout(1448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1448)]
	public class AInteractiveWaterLeaves : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060193DE RID: 103390 RVA: 0x002555ED File Offset: 0x002537ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AInteractiveWaterLeaves._ClassPtr;
		}

		// Token: 0x060193DF RID: 103391 RVA: 0x002555FC File Offset: 0x002537FC
		public AInteractiveWaterLeaves() : this(BuiltinUtils.AllocNativeUObject(AInteractiveWaterLeaves.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060193E0 RID: 103392 RVA: 0x00255624 File Offset: 0x00253824
		[NullableContext(1)]
		public AInteractiveWaterLeaves(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AInteractiveWaterLeaves.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170064A3 RID: 25763
		// (get) Token: 0x060193E1 RID: 103393 RVA: 0x00255657 File Offset: 0x00253857
		// (set) Token: 0x060193E2 RID: 103394 RVA: 0x0025566B File Offset: 0x0025386B
		public unsafe UInteractiveWaterLeavesConfig WaterLeavesConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInteractiveWaterLeavesConfig>(base.NativePtr / (IntPtr)sizeof(void*) + AInteractiveWaterLeaves.__PropertyOffset_WaterLeavesConfig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AInteractiveWaterLeaves.__PropertyOffset_WaterLeavesConfig, value);
			}
		}

		// Token: 0x170064A4 RID: 25764
		// (get) Token: 0x060193E3 RID: 103395 RVA: 0x00255680 File Offset: 0x00253880
		// (set) Token: 0x060193E4 RID: 103396 RVA: 0x00255694 File Offset: 0x00253894
		public unsafe UNiagaraComponent NiagaraComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AInteractiveWaterLeaves.__PropertyOffset_NiagaraComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AInteractiveWaterLeaves.__PropertyOffset_NiagaraComponent, value);
			}
		}

		// Token: 0x060193E5 RID: 103397 RVA: 0x002556A9 File Offset: 0x002538A9
		public void Refresh()
		{
			AInteractiveWaterLeaves.__Refresh_Internal(base.NativePtr);
		}

		// Token: 0x060193E6 RID: 103398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Refresh_Internal(IntPtr @this);

		// Token: 0x060193E7 RID: 103399 RVA: 0x002556B6 File Offset: 0x002538B6
		static AInteractiveWaterLeaves()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.InteractiveWaterLeaves");
		}

		// Token: 0x060193E8 RID: 103400 RVA: 0x002556C4 File Offset: 0x002538C4
		protected AInteractiveWaterLeaves(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC50 RID: 56400
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.InteractiveWaterLeaves";

		// Token: 0x0400DC51 RID: 56401
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC52 RID: 56402
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DC53 RID: 56403
		internal static int __PropertyOffset_WaterLeavesConfig;

		// Token: 0x0400DC54 RID: 56404
		internal static int __PropertyOffset_NiagaraComponent;
	}
}
