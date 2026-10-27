using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200049D RID: 1181
	[UnrealObjectPath("/Script/ColorCorrectRegions.ColorCorrectRegionsSubsystem")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UColorCorrectRegionsSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003F86 RID: 16262 RVA: 0x0005F688 File Offset: 0x0005D888
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UColorCorrectRegionsSubsystem._ClassPtr;
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x0005F694 File Offset: 0x0005D894
		public UColorCorrectRegionsSubsystem() : this(BuiltinUtils.AllocNativeUObject(UColorCorrectRegionsSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x0005F6BC File Offset: 0x0005D8BC
		[NullableContext(1)]
		public UColorCorrectRegionsSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UColorCorrectRegionsSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06003F89 RID: 16265 RVA: 0x0005F6F0 File Offset: 0x0005D8F0
		// (set) Token: 0x06003F8A RID: 16266 RVA: 0x0005F729 File Offset: 0x0005D929
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<AColorCorrectRegion>> Regions
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<AColorCorrectRegion>> result;
				if ((result = this._Regions) == null)
				{
					result = (this._Regions = new TArray<TWeakObjectPtr<AColorCorrectRegion>>(base.NativePtr + (IntPtr)UColorCorrectRegionsSubsystem.__PropertyOffset_Regions, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.Regions.CopyAssign(value);
			}
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x0005F738 File Offset: 0x0005D938
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnActorSpawned(AActor InActor)
		{
			UColorCorrectRegionsSubsystem.__OnActorSpawned_FunctionParams* ptr = stackalloc UColorCorrectRegionsSubsystem.__OnActorSpawned_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UColorCorrectRegionsSubsystem.__OnActorSpawned_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UColorCorrectRegionsSubsystem.__OnActorSpawned_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UColorCorrectRegionsSubsystem.__OnActorSpawned_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x0005F790 File Offset: 0x0005D990
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnActorDeleted(AActor InActor)
		{
			UColorCorrectRegionsSubsystem.__OnActorDeleted_FunctionParams* ptr = stackalloc UColorCorrectRegionsSubsystem.__OnActorDeleted_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UColorCorrectRegionsSubsystem.__OnActorDeleted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UColorCorrectRegionsSubsystem.__OnActorDeleted_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UColorCorrectRegionsSubsystem.__OnActorDeleted_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x0005F7E6 File Offset: 0x0005D9E6
		static UColorCorrectRegionsSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ColorCorrectRegions.ColorCorrectRegionsSubsystem");
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x0005F7F4 File Offset: 0x0005D9F4
		protected UColorCorrectRegionsSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001E10 RID: 7696
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ColorCorrectRegions.ColorCorrectRegionsSubsystem";

		// Token: 0x04001E11 RID: 7697
		private static IntPtr _ClassPtr;

		// Token: 0x04001E12 RID: 7698
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001E13 RID: 7699
		internal static int __PropertyOffset_Regions;

		// Token: 0x04001E14 RID: 7700
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AColorCorrectRegion>> _Regions;

		// Token: 0x04001E15 RID: 7701
		private static IntPtr __OnActorSpawned_NativeFunctionPtr;

		// Token: 0x04001E16 RID: 7702
		private static IntPtr __OnActorDeleted_NativeFunctionPtr;

		// Token: 0x02002C3B RID: 11323
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnActorSpawned_FunctionParams
		{
			// Token: 0x04016544 RID: 91460
			[FieldOffset(0)]
			public IntPtr InActor;
		}

		// Token: 0x02002C3C RID: 11324
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnActorDeleted_FunctionParams
		{
			// Token: 0x04016545 RID: 91461
			[FieldOffset(0)]
			public IntPtr InActor;
		}
	}
}
