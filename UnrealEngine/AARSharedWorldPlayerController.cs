using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C7 RID: 967
	[UnrealObjectPath("/Script/AugmentedReality.ARSharedWorldPlayerController")]
	[UnrealStructLayout(2040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2040)]
	public class AARSharedWorldPlayerController : APlayerController, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003630 RID: 13872 RVA: 0x000524D3 File Offset: 0x000506D3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AARSharedWorldPlayerController._ClassPtr;
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x000524E0 File Offset: 0x000506E0
		public AARSharedWorldPlayerController() : this(BuiltinUtils.AllocNativeUObject(AARSharedWorldPlayerController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x00052508 File Offset: 0x00050708
		[NullableContext(1)]
		public AARSharedWorldPlayerController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AARSharedWorldPlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x0005253B File Offset: 0x0005073B
		public void ServerMarkReadyForReceiving()
		{
			AARSharedWorldPlayerController.__ServerMarkReadyForReceiving_Internal(base.NativePtr);
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00052548 File Offset: 0x00050748
		[NullableContext(2)]
		public void ClientUpdatePreviewImageData(int Offset, in TArray<byte> Buffer)
		{
			AARSharedWorldPlayerController.__ClientUpdatePreviewImageData_Internal(base.NativePtr, Offset, (Buffer ?? new TArray<byte>()).NativePtr);
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x00052566 File Offset: 0x00050766
		[NullableContext(2)]
		public void ClientUpdateARWorldData(int Offset, in TArray<byte> Buffer)
		{
			AARSharedWorldPlayerController.__ClientUpdateARWorldData_Internal(base.NativePtr, Offset, (Buffer ?? new TArray<byte>()).NativePtr);
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x00052584 File Offset: 0x00050784
		public void ClientInitSharedWorld(int PreviewImageSize, int ARWorldDataSize)
		{
			AARSharedWorldPlayerController.__ClientInitSharedWorld_Internal(base.NativePtr, PreviewImageSize, ARWorldDataSize);
		}

		// Token: 0x06003637 RID: 13879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMarkReadyForReceiving_Internal(IntPtr @this);

		// Token: 0x06003638 RID: 13880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientUpdatePreviewImageData_Internal(IntPtr @this, int Offset, IntPtr Buffer);

		// Token: 0x06003639 RID: 13881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientUpdateARWorldData_Internal(IntPtr @this, int Offset, IntPtr Buffer);

		// Token: 0x0600363A RID: 13882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientInitSharedWorld_Internal(IntPtr @this, int PreviewImageSize, int ARWorldDataSize);

		// Token: 0x0600363B RID: 13883 RVA: 0x00052593 File Offset: 0x00050793
		static AARSharedWorldPlayerController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARSharedWorldPlayerController");
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x000525A1 File Offset: 0x000507A1
		protected AARSharedWorldPlayerController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400176F RID: 5999
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARSharedWorldPlayerController";

		// Token: 0x04001770 RID: 6000
		private static IntPtr _ClassPtr;

		// Token: 0x04001771 RID: 6001
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
