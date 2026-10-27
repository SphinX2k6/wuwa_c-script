using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ADB RID: 6875
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCustomShadowDepthWorldSubsystem")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UKuroCustomShadowDepthWorldSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060199D4 RID: 104916 RVA: 0x0025DBDA File Offset: 0x0025BDDA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCustomShadowDepthWorldSubsystem._ClassPtr;
		}

		// Token: 0x060199D5 RID: 104917 RVA: 0x0025DBE8 File Offset: 0x0025BDE8
		public UKuroCustomShadowDepthWorldSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroCustomShadowDepthWorldSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060199D6 RID: 104918 RVA: 0x0025DC10 File Offset: 0x0025BE10
		[NullableContext(1)]
		public UKuroCustomShadowDepthWorldSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCustomShadowDepthWorldSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060199D7 RID: 104919 RVA: 0x0025DC43 File Offset: 0x0025BE43
		public void SetViewSize(FIntPoint InViewSize)
		{
			UKuroCustomShadowDepthWorldSubsystem.__SetViewSize_Internal(base.NativePtr, InViewSize);
		}

		// Token: 0x060199D8 RID: 104920 RVA: 0x0025DC51 File Offset: 0x0025BE51
		public void SetShadowDepthRenderTarget(UTextureRenderTarget2D InRenderTarget)
		{
			UKuroCustomShadowDepthWorldSubsystem.__SetShadowDepthRenderTarget_Internal(base.NativePtr, (InRenderTarget != null) ? InRenderTarget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060199D9 RID: 104921 RVA: 0x0025DC6E File Offset: 0x0025BE6E
		public void SetCustomViewTransform(AActor ViewActor, float Width = 1000f, float Height = 1000f, float NearPlane = 1f, float FarPlane = 10000f)
		{
			UKuroCustomShadowDepthWorldSubsystem.__SetCustomViewTransform_Internal(base.NativePtr, (ViewActor != null) ? ViewActor.NativePtr : IntPtr.Zero, Width, Height, NearPlane, FarPlane);
		}

		// Token: 0x060199DA RID: 104922 RVA: 0x0025DC91 File Offset: 0x0025BE91
		public void RemoveActorFromRenderList(AActor Actor)
		{
			UKuroCustomShadowDepthWorldSubsystem.__RemoveActorFromRenderList_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060199DB RID: 104923 RVA: 0x0025DCAE File Offset: 0x0025BEAE
		public void ClearRenderList()
		{
			UKuroCustomShadowDepthWorldSubsystem.__ClearRenderList_Internal(base.NativePtr);
		}

		// Token: 0x060199DC RID: 104924 RVA: 0x0025DCBB File Offset: 0x0025BEBB
		public void ClearCustomViewTransform()
		{
			UKuroCustomShadowDepthWorldSubsystem.__ClearCustomViewTransform_Internal(base.NativePtr);
		}

		// Token: 0x060199DD RID: 104925 RVA: 0x0025DCC8 File Offset: 0x0025BEC8
		public void AddActorToRenderList(AActor Actor)
		{
			UKuroCustomShadowDepthWorldSubsystem.__AddActorToRenderList_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060199DE RID: 104926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetViewSize_Internal(IntPtr @this, FIntPoint InViewSize);

		// Token: 0x060199DF RID: 104927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowDepthRenderTarget_Internal(IntPtr @this, IntPtr InRenderTarget);

		// Token: 0x060199E0 RID: 104928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomViewTransform_Internal(IntPtr @this, IntPtr ViewActor, float Width, float Height, float NearPlane, float FarPlane);

		// Token: 0x060199E1 RID: 104929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveActorFromRenderList_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x060199E2 RID: 104930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearRenderList_Internal(IntPtr @this);

		// Token: 0x060199E3 RID: 104931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCustomViewTransform_Internal(IntPtr @this);

		// Token: 0x060199E4 RID: 104932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddActorToRenderList_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x060199E5 RID: 104933 RVA: 0x0025DCE5 File Offset: 0x0025BEE5
		static UKuroCustomShadowDepthWorldSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCustomShadowDepthWorldSubsystem");
		}

		// Token: 0x060199E6 RID: 104934 RVA: 0x0025DCF3 File Offset: 0x0025BEF3
		protected UKuroCustomShadowDepthWorldSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DF0A RID: 57098
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCustomShadowDepthWorldSubsystem";

		// Token: 0x0400DF0B RID: 57099
		private static IntPtr _ClassPtr;

		// Token: 0x0400DF0C RID: 57100
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
