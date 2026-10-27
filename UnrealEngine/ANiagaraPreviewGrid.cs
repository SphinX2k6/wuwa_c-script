using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025D6 RID: 9686
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraPreviewGrid")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class ANiagaraPreviewGrid : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023FD0 RID: 147408 RVA: 0x00353BC5 File Offset: 0x00351DC5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANiagaraPreviewGrid._ClassPtr;
		}

		// Token: 0x06023FD1 RID: 147409 RVA: 0x00353BD4 File Offset: 0x00351DD4
		public ANiagaraPreviewGrid() : this(BuiltinUtils.AllocNativeUObject(ANiagaraPreviewGrid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023FD2 RID: 147410 RVA: 0x00353BFC File Offset: 0x00351DFC
		[NullableContext(1)]
		public ANiagaraPreviewGrid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANiagaraPreviewGrid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A60 RID: 35424
		// (get) Token: 0x06023FD3 RID: 147411 RVA: 0x00353C2F File Offset: 0x00351E2F
		// (set) Token: 0x06023FD4 RID: 147412 RVA: 0x00353C43 File Offset: 0x00351E43
		public unsafe UNiagaraSystem System
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + ANiagaraPreviewGrid.__PropertyOffset_System);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANiagaraPreviewGrid.__PropertyOffset_System, value);
			}
		}

		// Token: 0x17008A61 RID: 35425
		// (get) Token: 0x06023FD5 RID: 147413 RVA: 0x00353C58 File Offset: 0x00351E58
		// (set) Token: 0x06023FD6 RID: 147414 RVA: 0x00353C68 File Offset: 0x00351E68
		public unsafe ENiagaraPreviewGridResetMode ResetMode
		{
			get
			{
				return (ENiagaraPreviewGridResetMode)(*(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_ResetMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_ResetMode) = (byte)value;
			}
		}

		// Token: 0x17008A62 RID: 35426
		// (get) Token: 0x06023FD7 RID: 147415 RVA: 0x00353C79 File Offset: 0x00351E79
		// (set) Token: 0x06023FD8 RID: 147416 RVA: 0x00353C8D File Offset: 0x00351E8D
		public unsafe UNiagaraPreviewAxis PreviewAxisX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraPreviewAxis>(base.NativePtr / (IntPtr)sizeof(void*) + ANiagaraPreviewGrid.__PropertyOffset_PreviewAxisX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANiagaraPreviewGrid.__PropertyOffset_PreviewAxisX, value);
			}
		}

		// Token: 0x17008A63 RID: 35427
		// (get) Token: 0x06023FD9 RID: 147417 RVA: 0x00353CA2 File Offset: 0x00351EA2
		// (set) Token: 0x06023FDA RID: 147418 RVA: 0x00353CB6 File Offset: 0x00351EB6
		public unsafe UNiagaraPreviewAxis PreviewAxisY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraPreviewAxis>(base.NativePtr / (IntPtr)sizeof(void*) + ANiagaraPreviewGrid.__PropertyOffset_PreviewAxisY);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANiagaraPreviewGrid.__PropertyOffset_PreviewAxisY, value);
			}
		}

		// Token: 0x17008A64 RID: 35428
		// (get) Token: 0x06023FDB RID: 147419 RVA: 0x00353CCB File Offset: 0x00351ECB
		// (set) Token: 0x06023FDC RID: 147420 RVA: 0x00353CDF File Offset: 0x00351EDF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<ANiagaraPreviewBase> PreviewClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_PreviewClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_PreviewClass) = value;
			}
		}

		// Token: 0x17008A65 RID: 35429
		// (get) Token: 0x06023FDD RID: 147421 RVA: 0x00353CF4 File Offset: 0x00351EF4
		// (set) Token: 0x06023FDE RID: 147422 RVA: 0x00353D04 File Offset: 0x00351F04
		public unsafe float SpacingX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_SpacingX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_SpacingX) = value;
			}
		}

		// Token: 0x17008A66 RID: 35430
		// (get) Token: 0x06023FDF RID: 147423 RVA: 0x00353D15 File Offset: 0x00351F15
		// (set) Token: 0x06023FE0 RID: 147424 RVA: 0x00353D25 File Offset: 0x00351F25
		public unsafe float SpacingY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_SpacingY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_SpacingY) = value;
			}
		}

		// Token: 0x17008A67 RID: 35431
		// (get) Token: 0x06023FE1 RID: 147425 RVA: 0x00353D36 File Offset: 0x00351F36
		// (set) Token: 0x06023FE2 RID: 147426 RVA: 0x00353D46 File Offset: 0x00351F46
		public unsafe int NumX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_NumX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_NumX) = value;
			}
		}

		// Token: 0x17008A68 RID: 35432
		// (get) Token: 0x06023FE3 RID: 147427 RVA: 0x00353D57 File Offset: 0x00351F57
		// (set) Token: 0x06023FE4 RID: 147428 RVA: 0x00353D67 File Offset: 0x00351F67
		public unsafe int NumY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_NumY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_NumY) = value;
			}
		}

		// Token: 0x17008A69 RID: 35433
		// (get) Token: 0x06023FE5 RID: 147429 RVA: 0x00353D78 File Offset: 0x00351F78
		// (set) Token: 0x06023FE6 RID: 147430 RVA: 0x00353DB1 File Offset: 0x00351FB1
		[Nullable(1)]
		public TArray<UChildActorComponent> PreviewComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UChildActorComponent> result;
				if ((result = this._PreviewComponents) == null)
				{
					result = (this._PreviewComponents = new TArray<UChildActorComponent>(base.NativePtr + (IntPtr)ANiagaraPreviewGrid.__PropertyOffset_PreviewComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PreviewComponents.CopyAssign(value);
			}
		}

		// Token: 0x06023FE7 RID: 147431 RVA: 0x00353DC0 File Offset: 0x00351FC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetPaused(bool bPaused)
		{
			ANiagaraPreviewGrid.__SetPaused_FunctionParams* ptr = stackalloc ANiagaraPreviewGrid.__SetPaused_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ANiagaraPreviewGrid.__SetPaused_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANiagaraPreviewGrid.__SetPaused_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bPaused = bPaused;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANiagaraPreviewGrid.__SetPaused_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023FE8 RID: 147432 RVA: 0x00353E08 File Offset: 0x00352008
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetPreviews([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UNiagaraComponent> OutPreviews)
		{
			ANiagaraPreviewGrid.__GetPreviews_FunctionParams* ptr = stackalloc ANiagaraPreviewGrid.__GetPreviews_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ANiagaraPreviewGrid.__GetPreviews_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANiagaraPreviewGrid.__GetPreviews_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UNiagaraComponent> tarray = OutPreviews;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutPreviews);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANiagaraPreviewGrid.__GetPreviews_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UNiagaraComponent> tarray2 = OutPreviews;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutPreviews);
			}
			UnrealReflectionUtils.DestroyStruct(ANiagaraPreviewGrid.__GetPreviews_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06023FE9 RID: 147433 RVA: 0x00353E81 File Offset: 0x00352081
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void DeactivatePreviews()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANiagaraPreviewGrid.__DeactivatePreviews_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023FEA RID: 147434 RVA: 0x00353E98 File Offset: 0x00352098
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ActivatePreviews(bool bReset)
		{
			ANiagaraPreviewGrid.__ActivatePreviews_FunctionParams* ptr = stackalloc ANiagaraPreviewGrid.__ActivatePreviews_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ANiagaraPreviewGrid.__ActivatePreviews_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANiagaraPreviewGrid.__ActivatePreviews_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bReset = bReset;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANiagaraPreviewGrid.__ActivatePreviews_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023FEB RID: 147435 RVA: 0x00353EDF File Offset: 0x003520DF
		static ANiagaraPreviewGrid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraPreviewGrid");
		}

		// Token: 0x06023FEC RID: 147436 RVA: 0x00353EED File Offset: 0x003520ED
		protected ANiagaraPreviewGrid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040134BA RID: 79034
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraPreviewGrid";

		// Token: 0x040134BB RID: 79035
		private static IntPtr _ClassPtr;

		// Token: 0x040134BC RID: 79036
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040134BD RID: 79037
		internal static int __PropertyOffset_System;

		// Token: 0x040134BE RID: 79038
		internal static int __PropertyOffset_ResetMode;

		// Token: 0x040134BF RID: 79039
		internal static int __PropertyOffset_PreviewAxisX;

		// Token: 0x040134C0 RID: 79040
		internal static int __PropertyOffset_PreviewAxisY;

		// Token: 0x040134C1 RID: 79041
		internal static int __PropertyOffset_PreviewClass;

		// Token: 0x040134C2 RID: 79042
		internal static int __PropertyOffset_SpacingX;

		// Token: 0x040134C3 RID: 79043
		internal static int __PropertyOffset_SpacingY;

		// Token: 0x040134C4 RID: 79044
		internal static int __PropertyOffset_NumX;

		// Token: 0x040134C5 RID: 79045
		internal static int __PropertyOffset_NumY;

		// Token: 0x040134C6 RID: 79046
		internal static int __PropertyOffset_PreviewComponents;

		// Token: 0x040134C7 RID: 79047
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UChildActorComponent> _PreviewComponents;

		// Token: 0x040134C8 RID: 79048
		private static IntPtr __SetPaused_NativeFunctionPtr;

		// Token: 0x040134C9 RID: 79049
		private static IntPtr __GetPreviews_NativeFunctionPtr;

		// Token: 0x040134CA RID: 79050
		private static IntPtr __DeactivatePreviews_NativeFunctionPtr;

		// Token: 0x040134CB RID: 79051
		private static IntPtr __ActivatePreviews_NativeFunctionPtr;

		// Token: 0x02003674 RID: 13940
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetPaused_FunctionParams
		{
			// Token: 0x0401774B RID: 96075
			[FieldOffset(0)]
			public bool bPaused;
		}

		// Token: 0x02003675 RID: 13941
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetPreviews_FunctionParams
		{
			// Token: 0x0401774C RID: 96076
			[FieldOffset(0)]
			public byte OutPreviews;
		}

		// Token: 0x02003676 RID: 13942
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ActivatePreviews_FunctionParams
		{
			// Token: 0x0401774D RID: 96077
			[FieldOffset(0)]
			public bool bReset;
		}
	}
}
