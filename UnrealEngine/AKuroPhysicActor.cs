using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B8C RID: 7052
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPhysicActor")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class AKuroPhysicActor : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AC19 RID: 109593 RVA: 0x00276E6E File Offset: 0x0027506E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroPhysicActor._ClassPtr;
		}

		// Token: 0x0601AC1A RID: 109594 RVA: 0x00276E7C File Offset: 0x0027507C
		public AKuroPhysicActor() : this(BuiltinUtils.AllocNativeUObject(AKuroPhysicActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AC1B RID: 109595 RVA: 0x00276EA4 File Offset: 0x002750A4
		[NullableContext(1)]
		public AKuroPhysicActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroPhysicActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601AC1C RID: 109596 RVA: 0x00276ED7 File Offset: 0x002750D7
		public virtual void OpenPhysicsVisibility()
		{
			AKuroPhysicActor.__OpenPhysicsVisibility_Internal(base.NativePtr);
		}

		// Token: 0x0601AC1D RID: 109597 RVA: 0x00276EE4 File Offset: 0x002750E4
		protected virtual void OpenPhysicsVisibility_Implementation()
		{
			AKuroPhysicActor.__OpenPhysicsVisibility_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0601AC1E RID: 109598 RVA: 0x00276EF1 File Offset: 0x002750F1
		public virtual void ClosePhysicsVisibility()
		{
			AKuroPhysicActor.__ClosePhysicsVisibility_Internal(base.NativePtr);
		}

		// Token: 0x0601AC1F RID: 109599 RVA: 0x00276EFE File Offset: 0x002750FE
		protected virtual void ClosePhysicsVisibility_Implementation()
		{
			AKuroPhysicActor.__ClosePhysicsVisibility_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0601AC20 RID: 109600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenPhysicsVisibility_Internal(IntPtr @this);

		// Token: 0x0601AC21 RID: 109601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenPhysicsVisibility_Implementation_Internal(IntPtr @this);

		// Token: 0x0601AC22 RID: 109602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClosePhysicsVisibility_Internal(IntPtr @this);

		// Token: 0x0601AC23 RID: 109603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClosePhysicsVisibility_Implementation_Internal(IntPtr @this);

		// Token: 0x0601AC24 RID: 109604 RVA: 0x00276F0B File Offset: 0x0027510B
		static AKuroPhysicActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPhysicActor");
		}

		// Token: 0x0601AC25 RID: 109605 RVA: 0x00276F19 File Offset: 0x00275119
		protected AKuroPhysicActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E79F RID: 59295
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPhysicActor";

		// Token: 0x0400E7A0 RID: 59296
		private static IntPtr _ClassPtr;

		// Token: 0x0400E7A1 RID: 59297
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
