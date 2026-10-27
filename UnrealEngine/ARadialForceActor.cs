using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001062 RID: 4194
	[UnrealObjectPath("/Script/Engine.RadialForceActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ARadialForceActor : ARigidBodyBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600EE9C RID: 61084 RVA: 0x00161F58 File Offset: 0x00160158
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ARadialForceActor._ClassPtr;
		}

		// Token: 0x0600EE9D RID: 61085 RVA: 0x00161F64 File Offset: 0x00160164
		public ARadialForceActor() : this(BuiltinUtils.AllocNativeUObject(ARadialForceActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600EE9E RID: 61086 RVA: 0x00161F8C File Offset: 0x0016018C
		[NullableContext(1)]
		public ARadialForceActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ARadialForceActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x0600EE9F RID: 61087 RVA: 0x00161FBF File Offset: 0x001601BF
		// (set) Token: 0x0600EEA0 RID: 61088 RVA: 0x00161FD3 File Offset: 0x001601D3
		[Nullable(2)]
		public unsafe URadialForceComponent ForceComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URadialForceComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ARadialForceActor.__PropertyOffset_ForceComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ARadialForceActor.__PropertyOffset_ForceComponent, value);
			}
		}

		// Token: 0x0600EEA1 RID: 61089 RVA: 0x00161FE8 File Offset: 0x001601E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ToggleForce()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARadialForceActor.__ToggleForce_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0600EEA2 RID: 61090 RVA: 0x00161FFD File Offset: 0x001601FD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void FireImpulse()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARadialForceActor.__FireImpulse_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0600EEA3 RID: 61091 RVA: 0x00162012 File Offset: 0x00160212
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EnableForce()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARadialForceActor.__EnableForce_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0600EEA4 RID: 61092 RVA: 0x00162027 File Offset: 0x00160227
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void DisableForce()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARadialForceActor.__DisableForce_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0600EEA5 RID: 61093 RVA: 0x0016203C File Offset: 0x0016023C
		static ARadialForceActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RadialForceActor");
		}

		// Token: 0x0600EEA6 RID: 61094 RVA: 0x0016204A File Offset: 0x0016024A
		protected ARadialForceActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008124 RID: 33060
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RadialForceActor";

		// Token: 0x04008125 RID: 33061
		private static IntPtr _ClassPtr;

		// Token: 0x04008126 RID: 33062
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008127 RID: 33063
		internal static int __PropertyOffset_ForceComponent;

		// Token: 0x04008128 RID: 33064
		private static IntPtr __ToggleForce_NativeFunctionPtr;

		// Token: 0x04008129 RID: 33065
		private static IntPtr __FireImpulse_NativeFunctionPtr;

		// Token: 0x0400812A RID: 33066
		private static IntPtr __EnableForce_NativeFunctionPtr;

		// Token: 0x0400812B RID: 33067
		private static IntPtr __DisableForce_NativeFunctionPtr;
	}
}
