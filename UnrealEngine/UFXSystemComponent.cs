using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BF8 RID: 3064
	[UnrealObjectPath("/Script/Engine.FXSystemComponent")]
	[UnrealStructLayout(1568, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public abstract class UFXSystemComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600972D RID: 38701 RVA: 0x000D7969 File Offset: 0x000D5B69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFXSystemComponent._ClassPtr;
		}

		// Token: 0x0600972E RID: 38702 RVA: 0x000D7975 File Offset: 0x000D5B75
		public void SetVectorParameter(FName ParameterName, FVector Param)
		{
			UFXSystemComponent.__SetVectorParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x0600972F RID: 38703 RVA: 0x000D7984 File Offset: 0x000D5B84
		public void SetUseAutoManageAttachment(bool bAutoManage)
		{
			UFXSystemComponent.__SetUseAutoManageAttachment_Internal(base.NativePtr, bAutoManage);
		}

		// Token: 0x06009730 RID: 38704 RVA: 0x000D7992 File Offset: 0x000D5B92
		public void SetIntParameter(FName ParameterName, int Param)
		{
			UFXSystemComponent.__SetIntParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x06009731 RID: 38705 RVA: 0x000D79A1 File Offset: 0x000D5BA1
		public void SetFloatParameter(FName ParameterName, float Param)
		{
			UFXSystemComponent.__SetFloatParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x06009732 RID: 38706 RVA: 0x000D79B0 File Offset: 0x000D5BB0
		public void SetEmitterEnable(FName EmitterName, bool bNewEnableState)
		{
			UFXSystemComponent.__SetEmitterEnable_Internal(base.NativePtr, EmitterName, bNewEnableState);
		}

		// Token: 0x06009733 RID: 38707 RVA: 0x000D79BF File Offset: 0x000D5BBF
		public void SetColorParameter(FName ParameterName, FLinearColor Param)
		{
			UFXSystemComponent.__SetColorParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x06009734 RID: 38708 RVA: 0x000D79CE File Offset: 0x000D5BCE
		public void SetBoolParameter(FName ParameterName, bool Param)
		{
			UFXSystemComponent.__SetBoolParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x06009735 RID: 38709 RVA: 0x000D79DD File Offset: 0x000D5BDD
		[NullableContext(2)]
		public void SetAutoAttachmentParameters(USceneComponent Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule)
		{
			UFXSystemComponent.__SetAutoAttachmentParameters_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule);
		}

		// Token: 0x06009736 RID: 38710 RVA: 0x000D7A00 File Offset: 0x000D5C00
		[NullableContext(2)]
		public void SetActorParameter(FName ParameterName, AActor Param)
		{
			UFXSystemComponent.__SetActorParameter_Internal(base.NativePtr, ParameterName, (Param != null) ? Param.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009737 RID: 38711 RVA: 0x000D7A1E File Offset: 0x000D5C1E
		public void ReleaseToPool()
		{
			UFXSystemComponent.__ReleaseToPool_Internal(base.NativePtr);
		}

		// Token: 0x06009738 RID: 38712 RVA: 0x000D7A2B File Offset: 0x000D5C2B
		[NullableContext(2)]
		public UFXSystemAsset GetFXSystemAsset()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UFXSystemAsset>(UFXSystemComponent.__GetFXSystemAsset_Internal(base.NativePtr));
		}

		// Token: 0x06009739 RID: 38713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameter_Internal(IntPtr @this, FName ParameterName, FVector Param);

		// Token: 0x0600973A RID: 38714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseAutoManageAttachment_Internal(IntPtr @this, bool bAutoManage);

		// Token: 0x0600973B RID: 38715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntParameter_Internal(IntPtr @this, FName ParameterName, int Param);

		// Token: 0x0600973C RID: 38716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloatParameter_Internal(IntPtr @this, FName ParameterName, float Param);

		// Token: 0x0600973D RID: 38717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEmitterEnable_Internal(IntPtr @this, FName EmitterName, bool bNewEnableState);

		// Token: 0x0600973E RID: 38718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorParameter_Internal(IntPtr @this, FName ParameterName, FLinearColor Param);

		// Token: 0x0600973F RID: 38719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoolParameter_Internal(IntPtr @this, FName ParameterName, bool Param);

		// Token: 0x06009740 RID: 38720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoAttachmentParameters_Internal(IntPtr @this, IntPtr Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule);

		// Token: 0x06009741 RID: 38721
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorParameter_Internal(IntPtr @this, FName ParameterName, IntPtr Param);

		// Token: 0x06009742 RID: 38722
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseToPool_Internal(IntPtr @this);

		// Token: 0x06009743 RID: 38723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFXSystemAsset_Internal(IntPtr @this);

		// Token: 0x06009744 RID: 38724 RVA: 0x000D7A3D File Offset: 0x000D5C3D
		static UFXSystemComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.FXSystemComponent");
		}

		// Token: 0x06009745 RID: 38725 RVA: 0x000D7A4C File Offset: 0x000D5C4C
		protected UFXSystemComponent() : this(BuiltinUtils.AllocNativeUObject(UFXSystemComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009746 RID: 38726 RVA: 0x000D7A74 File Offset: 0x000D5C74
		protected UFXSystemComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054C1 RID: 21697
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.FXSystemComponent";

		// Token: 0x040054C2 RID: 21698
		private static IntPtr _ClassPtr;

		// Token: 0x040054C3 RID: 21699
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
