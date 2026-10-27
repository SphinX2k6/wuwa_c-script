using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000825 RID: 2085
	[UnrealObjectPath("/Script/Engine.AnimNotify")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UAnimNotify : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007026 RID: 28710 RVA: 0x000A0E2B File Offset: 0x0009F02B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotify._ClassPtr;
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x06007027 RID: 28711 RVA: 0x000A0E37 File Offset: 0x0009F037
		// (set) Token: 0x06007028 RID: 28712 RVA: 0x000A0E47 File Offset: 0x0009F047
		public unsafe bool NeedSimulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify.__PropertyOffset_NeedSimulate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify.__PropertyOffset_NeedSimulate) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007029 RID: 28713 RVA: 0x000A0E58 File Offset: 0x0009F058
		[NullableContext(2)]
		public virtual bool Received_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UAnimNotify.__Received_Notify_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600702A RID: 28714 RVA: 0x000A0E85 File Offset: 0x0009F085
		[NullableContext(1)]
		public virtual string GetNotifyName()
		{
			return FString.ToStringAndDeleteNativePtr(UAnimNotify.__GetNotifyName_Internal(base.NativePtr));
		}

		// Token: 0x0600702B RID: 28715 RVA: 0x000A0E97 File Offset: 0x0009F097
		[NullableContext(1)]
		protected virtual string GetNotifyName_Implementation()
		{
			return FString.ToStringAndDeleteNativePtr(UAnimNotify.__GetNotifyName_Implementation_Internal(base.NativePtr));
		}

		// Token: 0x0600702C RID: 28716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Received_Notify_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x0600702D RID: 28717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetNotifyName_Internal(IntPtr @this);

		// Token: 0x0600702E RID: 28718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetNotifyName_Implementation_Internal(IntPtr @this);

		// Token: 0x0600702F RID: 28719 RVA: 0x000A0EA9 File Offset: 0x0009F0A9
		static UAnimNotify()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotify");
		}

		// Token: 0x06007030 RID: 28720 RVA: 0x000A0EB8 File Offset: 0x0009F0B8
		protected UAnimNotify() : this(BuiltinUtils.AllocNativeUObject(UAnimNotify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007031 RID: 28721 RVA: 0x000A0EE0 File Offset: 0x0009F0E0
		protected UAnimNotify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040035DC RID: 13788
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotify";

		// Token: 0x040035DD RID: 13789
		private static IntPtr _ClassPtr;

		// Token: 0x040035DE RID: 13790
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040035DF RID: 13791
		internal static int __PropertyOffset_NeedSimulate;

		// Token: 0x02002C85 RID: 11397
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Received_Notify_FunctionParams
		{
			// Token: 0x040165BE RID: 91582
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x040165BF RID: 91583
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x040165C0 RID: 91584
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02002C86 RID: 11398
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNotifyName_FunctionParams
		{
			// Token: 0x040165C1 RID: 91585
			[FieldOffset(0)]
			public FString __Result;
		}
	}
}
