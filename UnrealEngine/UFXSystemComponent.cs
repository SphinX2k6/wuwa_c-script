using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000212 RID: 530
	[UnrealObjectPath("/Script/Engine.FXSystemComponent")]
	[UnrealStructLayout(1568, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public abstract class UFXSystemComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060021F8 RID: 8696 RVA: 0x00031C9D File Offset: 0x0002FE9D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFXSystemComponent._ClassPtr;
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00031CA9 File Offset: 0x0002FEA9
		public void SetVectorParameter(FName ParameterName, FVector Param)
		{
			UFXSystemComponent.__SetVectorParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x00031CB8 File Offset: 0x0002FEB8
		public void SetUseAutoManageAttachment(bool bAutoManage)
		{
			UFXSystemComponent.__SetUseAutoManageAttachment_Internal(base.NativePtr, bAutoManage);
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00031CC6 File Offset: 0x0002FEC6
		public void SetIntParameter(FName ParameterName, int Param)
		{
			UFXSystemComponent.__SetIntParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x00031CD5 File Offset: 0x0002FED5
		public void SetFloatParameter(FName ParameterName, float Param)
		{
			UFXSystemComponent.__SetFloatParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x00031CE4 File Offset: 0x0002FEE4
		public void SetEmitterEnable(FName EmitterName, bool bNewEnableState)
		{
			UFXSystemComponent.__SetEmitterEnable_Internal(base.NativePtr, EmitterName, bNewEnableState);
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00031CF3 File Offset: 0x0002FEF3
		public void SetColorParameter(FName ParameterName, FLinearColor Param)
		{
			UFXSystemComponent.__SetColorParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00031D02 File Offset: 0x0002FF02
		public void SetBoolParameter(FName ParameterName, bool Param)
		{
			UFXSystemComponent.__SetBoolParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00031D11 File Offset: 0x0002FF11
		[NullableContext(2)]
		public void SetAutoAttachmentParameters(USceneComponent Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule)
		{
			UFXSystemComponent.__SetAutoAttachmentParameters_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule);
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00031D34 File Offset: 0x0002FF34
		[NullableContext(2)]
		public void SetActorParameter(FName ParameterName, AActor Param)
		{
			UFXSystemComponent.__SetActorParameter_Internal(base.NativePtr, ParameterName, (Param != null) ? Param.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00031D52 File Offset: 0x0002FF52
		public void ReleaseToPool()
		{
			UFXSystemComponent.__ReleaseToPool_Internal(base.NativePtr);
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x00031D5F File Offset: 0x0002FF5F
		[NullableContext(2)]
		public UFXSystemAsset GetFXSystemAsset()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UFXSystemAsset>(UFXSystemComponent.__GetFXSystemAsset_Internal(base.NativePtr));
		}

		// Token: 0x06002204 RID: 8708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameter_Internal(IntPtr @this, FName ParameterName, FVector Param);

		// Token: 0x06002205 RID: 8709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseAutoManageAttachment_Internal(IntPtr @this, bool bAutoManage);

		// Token: 0x06002206 RID: 8710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntParameter_Internal(IntPtr @this, FName ParameterName, int Param);

		// Token: 0x06002207 RID: 8711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloatParameter_Internal(IntPtr @this, FName ParameterName, float Param);

		// Token: 0x06002208 RID: 8712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEmitterEnable_Internal(IntPtr @this, FName EmitterName, bool bNewEnableState);

		// Token: 0x06002209 RID: 8713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorParameter_Internal(IntPtr @this, FName ParameterName, FLinearColor Param);

		// Token: 0x0600220A RID: 8714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoolParameter_Internal(IntPtr @this, FName ParameterName, bool Param);

		// Token: 0x0600220B RID: 8715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoAttachmentParameters_Internal(IntPtr @this, IntPtr Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule);

		// Token: 0x0600220C RID: 8716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorParameter_Internal(IntPtr @this, FName ParameterName, IntPtr Param);

		// Token: 0x0600220D RID: 8717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseToPool_Internal(IntPtr @this);

		// Token: 0x0600220E RID: 8718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFXSystemAsset_Internal(IntPtr @this);

		// Token: 0x0600220F RID: 8719 RVA: 0x00031D71 File Offset: 0x0002FF71
		static UFXSystemComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.FXSystemComponent");
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x00031D80 File Offset: 0x0002FF80
		protected UFXSystemComponent() : this(BuiltinUtils.AllocNativeUObject(UFXSystemComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00031DA8 File Offset: 0x0002FFA8
		protected UFXSystemComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000D51 RID: 3409
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.FXSystemComponent";

		// Token: 0x04000D52 RID: 3410
		private static IntPtr _ClassPtr;

		// Token: 0x04000D53 RID: 3411
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
