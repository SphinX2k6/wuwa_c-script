using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D7 RID: 1239
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPhysicActor")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class AKuroPhysicActor : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060073A6 RID: 29606 RVA: 0x000A98E6 File Offset: 0x000A7AE6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroPhysicActor._ClassPtr;
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x000A98F4 File Offset: 0x000A7AF4
		public AKuroPhysicActor() : this(BuiltinUtils.AllocNativeUObject(AKuroPhysicActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x000A991C File Offset: 0x000A7B1C
		[NullableContext(1)]
		public AKuroPhysicActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroPhysicActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x000A994F File Offset: 0x000A7B4F
		public virtual void OpenPhysicsVisibility()
		{
			AKuroPhysicActor.__OpenPhysicsVisibility_Internal(base.NativePtr);
		}

		// Token: 0x060073AA RID: 29610 RVA: 0x000A995C File Offset: 0x000A7B5C
		protected virtual void OpenPhysicsVisibility_Implementation()
		{
			AKuroPhysicActor.__OpenPhysicsVisibility_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x000A9969 File Offset: 0x000A7B69
		public virtual void ClosePhysicsVisibility()
		{
			AKuroPhysicActor.__ClosePhysicsVisibility_Internal(base.NativePtr);
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x000A9976 File Offset: 0x000A7B76
		protected virtual void ClosePhysicsVisibility_Implementation()
		{
			AKuroPhysicActor.__ClosePhysicsVisibility_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060073AD RID: 29613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenPhysicsVisibility_Internal(IntPtr @this);

		// Token: 0x060073AE RID: 29614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenPhysicsVisibility_Implementation_Internal(IntPtr @this);

		// Token: 0x060073AF RID: 29615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClosePhysicsVisibility_Internal(IntPtr @this);

		// Token: 0x060073B0 RID: 29616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClosePhysicsVisibility_Implementation_Internal(IntPtr @this);

		// Token: 0x060073B1 RID: 29617 RVA: 0x000A9983 File Offset: 0x000A7B83
		static AKuroPhysicActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPhysicActor");
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x000A9991 File Offset: 0x000A7B91
		protected AKuroPhysicActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003190 RID: 12688
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPhysicActor";

		// Token: 0x04003191 RID: 12689
		private static IntPtr _ClassPtr;

		// Token: 0x04003192 RID: 12690
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
