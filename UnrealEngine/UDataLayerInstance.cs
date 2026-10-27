using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000996 RID: 2454
	[UnrealObjectPath("/Script/Engine.DataLayerInstance")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UDataLayerInstance : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008AA3 RID: 35491 RVA: 0x000C67D5 File Offset: 0x000C49D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataLayerInstance._ClassPtr;
		}

		// Token: 0x06008AA4 RID: 35492 RVA: 0x000C67E4 File Offset: 0x000C49E4
		public UDataLayerInstance() : this(BuiltinUtils.AllocNativeUObject(UDataLayerInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008AA5 RID: 35493 RVA: 0x000C680C File Offset: 0x000C4A0C
		[NullableContext(1)]
		public UDataLayerInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataLayerInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x06008AA6 RID: 35494 RVA: 0x000C683F File Offset: 0x000C4A3F
		// (set) Token: 0x06008AA7 RID: 35495 RVA: 0x000C684F File Offset: 0x000C4A4F
		public unsafe EDataLayerRuntimeState InitialRuntimeState
		{
			get
			{
				return (EDataLayerRuntimeState)(*(base.NativePtr + (IntPtr)UDataLayerInstance.__PropertyOffset_InitialRuntimeState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDataLayerInstance.__PropertyOffset_InitialRuntimeState) = (byte)value;
			}
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x06008AA8 RID: 35496 RVA: 0x000C6860 File Offset: 0x000C4A60
		// (set) Token: 0x06008AA9 RID: 35497 RVA: 0x000C6874 File Offset: 0x000C4A74
		[Nullable(2)]
		public unsafe UDataLayerInstance Parent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataLayerInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UDataLayerInstance.__PropertyOffset_Parent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDataLayerInstance.__PropertyOffset_Parent, value);
			}
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x06008AAA RID: 35498 RVA: 0x000C688C File Offset: 0x000C4A8C
		// (set) Token: 0x06008AAB RID: 35499 RVA: 0x000C68C5 File Offset: 0x000C4AC5
		[Nullable(1)]
		public TArray<UDataLayerInstance> Children
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UDataLayerInstance> result;
				if ((result = this._Children) == null)
				{
					result = (this._Children = new TArray<UDataLayerInstance>(base.NativePtr + (IntPtr)UDataLayerInstance.__PropertyOffset_Children, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Children.CopyAssign(value);
			}
		}

		// Token: 0x06008AAC RID: 35500 RVA: 0x000C68D3 File Offset: 0x000C4AD3
		public bool IsVisible()
		{
			return UDataLayerInstance.__IsVisible_Internal(base.NativePtr);
		}

		// Token: 0x06008AAD RID: 35501 RVA: 0x000C68E0 File Offset: 0x000C4AE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsServerOnly()
		{
			UDataLayerInstance.__IsServerOnly_FunctionParams* ptr = stackalloc UDataLayerInstance.__IsServerOnly_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UDataLayerInstance.__IsServerOnly_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerInstance.__IsServerOnly_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerInstance.__IsServerOnly_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x000C6928 File Offset: 0x000C4B28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRuntime()
		{
			UDataLayerInstance.__IsRuntime_FunctionParams* ptr = stackalloc UDataLayerInstance.__IsRuntime_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UDataLayerInstance.__IsRuntime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerInstance.__IsRuntime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerInstance.__IsRuntime_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x000C696E File Offset: 0x000C4B6E
		public bool IsInitiallyVisible()
		{
			return UDataLayerInstance.__IsInitiallyVisible_Internal(base.NativePtr);
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x000C697B File Offset: 0x000C4B7B
		public bool IsEffectiveVisible()
		{
			return UDataLayerInstance.__IsEffectiveVisible_Internal(base.NativePtr);
		}

		// Token: 0x06008AB1 RID: 35505 RVA: 0x000C6988 File Offset: 0x000C4B88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsClientOnly()
		{
			UDataLayerInstance.__IsClientOnly_FunctionParams* ptr = stackalloc UDataLayerInstance.__IsClientOnly_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UDataLayerInstance.__IsClientOnly_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerInstance.__IsClientOnly_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerInstance.__IsClientOnly_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06008AB2 RID: 35506 RVA: 0x000C69D0 File Offset: 0x000C4BD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public new unsafe EDataLayerType GetType()
		{
			UDataLayerInstance.__GetType_FunctionParams* ptr = stackalloc UDataLayerInstance.__GetType_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UDataLayerInstance.__GetType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerInstance.__GetType_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerInstance.__GetType_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x000C6A18 File Offset: 0x000C4C18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe EDataLayerRuntimeState GetInitialRuntimeState()
		{
			UDataLayerInstance.__GetInitialRuntimeState_FunctionParams* ptr = stackalloc UDataLayerInstance.__GetInitialRuntimeState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UDataLayerInstance.__GetInitialRuntimeState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerInstance.__GetInitialRuntimeState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerInstance.__GetInitialRuntimeState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x000C6A60 File Offset: 0x000C4C60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FColor GetDebugColor()
		{
			UDataLayerInstance.__GetDebugColor_FunctionParams* ptr = stackalloc UDataLayerInstance.__GetDebugColor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UDataLayerInstance.__GetDebugColor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerInstance.__GetDebugColor_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerInstance.__GetDebugColor_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06008AB5 RID: 35509 RVA: 0x000C6AA8 File Offset: 0x000C4CA8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe string GetDataLayerShortName()
		{
			UDataLayerInstance.__GetDataLayerShortName_FunctionParams* ptr = stackalloc UDataLayerInstance.__GetDataLayerShortName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UDataLayerInstance.__GetDataLayerShortName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerInstance.__GetDataLayerShortName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerInstance.__GetDataLayerShortName_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UDataLayerInstance.__GetDataLayerShortName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06008AB6 RID: 35510 RVA: 0x000C6B08 File Offset: 0x000C4D08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe string GetDataLayerFullName()
		{
			UDataLayerInstance.__GetDataLayerFullName_FunctionParams* ptr = stackalloc UDataLayerInstance.__GetDataLayerFullName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UDataLayerInstance.__GetDataLayerFullName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerInstance.__GetDataLayerFullName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerInstance.__GetDataLayerFullName_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UDataLayerInstance.__GetDataLayerFullName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06008AB7 RID: 35511 RVA: 0x000C6B68 File Offset: 0x000C4D68
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UDataLayerAsset GetAsset()
		{
			UDataLayerInstance.__GetAsset_FunctionParams* ptr = stackalloc UDataLayerInstance.__GetAsset_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UDataLayerInstance.__GetAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerInstance.__GetAsset_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerInstance.__GetAsset_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDataLayerAsset>(ptr->__Result);
		}

		// Token: 0x06008AB8 RID: 35512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVisible_Internal(IntPtr @this);

		// Token: 0x06008AB9 RID: 35513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInitiallyVisible_Internal(IntPtr @this);

		// Token: 0x06008ABA RID: 35514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEffectiveVisible_Internal(IntPtr @this);

		// Token: 0x06008ABB RID: 35515 RVA: 0x000C6BB3 File Offset: 0x000C4DB3
		static UDataLayerInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataLayerInstance");
		}

		// Token: 0x06008ABC RID: 35516 RVA: 0x000C6BC1 File Offset: 0x000C4DC1
		protected UDataLayerInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041D2 RID: 16850
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DataLayerInstance";

		// Token: 0x040041D3 RID: 16851
		private static IntPtr _ClassPtr;

		// Token: 0x040041D4 RID: 16852
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041D5 RID: 16853
		internal static int __PropertyOffset_InitialRuntimeState;

		// Token: 0x040041D6 RID: 16854
		internal static int __PropertyOffset_Parent;

		// Token: 0x040041D7 RID: 16855
		internal static int __PropertyOffset_Children;

		// Token: 0x040041D8 RID: 16856
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UDataLayerInstance> _Children;

		// Token: 0x040041D9 RID: 16857
		private static IntPtr __IsServerOnly_NativeFunctionPtr;

		// Token: 0x040041DA RID: 16858
		private static IntPtr __IsRuntime_NativeFunctionPtr;

		// Token: 0x040041DB RID: 16859
		private static IntPtr __IsClientOnly_NativeFunctionPtr;

		// Token: 0x040041DC RID: 16860
		private static IntPtr __GetType_NativeFunctionPtr;

		// Token: 0x040041DD RID: 16861
		private static IntPtr __GetInitialRuntimeState_NativeFunctionPtr;

		// Token: 0x040041DE RID: 16862
		private static IntPtr __GetDebugColor_NativeFunctionPtr;

		// Token: 0x040041DF RID: 16863
		private static IntPtr __GetDataLayerShortName_NativeFunctionPtr;

		// Token: 0x040041E0 RID: 16864
		private static IntPtr __GetDataLayerFullName_NativeFunctionPtr;

		// Token: 0x040041E1 RID: 16865
		private static IntPtr __GetAsset_NativeFunctionPtr;

		// Token: 0x02002CEE RID: 11502
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsServerOnly_FunctionParams
		{
			// Token: 0x040166A0 RID: 91808
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002CEF RID: 11503
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRuntime_FunctionParams
		{
			// Token: 0x040166A1 RID: 91809
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002CF0 RID: 11504
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsClientOnly_FunctionParams
		{
			// Token: 0x040166A2 RID: 91810
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002CF1 RID: 11505
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetType_FunctionParams
		{
			// Token: 0x040166A3 RID: 91811
			[FieldOffset(0)]
			public EDataLayerType __Result;
		}

		// Token: 0x02002CF2 RID: 11506
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetInitialRuntimeState_FunctionParams
		{
			// Token: 0x040166A4 RID: 91812
			[FieldOffset(0)]
			public EDataLayerRuntimeState __Result;
		}

		// Token: 0x02002CF3 RID: 11507
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetDebugColor_FunctionParams
		{
			// Token: 0x040166A5 RID: 91813
			[FieldOffset(0)]
			public FColor __Result;
		}

		// Token: 0x02002CF4 RID: 11508
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetDataLayerShortName_FunctionParams
		{
			// Token: 0x040166A6 RID: 91814
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02002CF5 RID: 11509
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetDataLayerFullName_FunctionParams
		{
			// Token: 0x040166A7 RID: 91815
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02002CF6 RID: 11510
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetAsset_FunctionParams
		{
			// Token: 0x040166A8 RID: 91816
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
