using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200017B RID: 379
	[UnrealObjectPath("/Script/Engine.AnimNotify")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UAnimNotify : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600180A RID: 6154 RVA: 0x00024CF4 File Offset: 0x00022EF4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotify._ClassPtr;
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x00024D00 File Offset: 0x00022F00
		// (set) Token: 0x0600180C RID: 6156 RVA: 0x00024D10 File Offset: 0x00022F10
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

		// Token: 0x0600180D RID: 6157 RVA: 0x00024D21 File Offset: 0x00022F21
		[NullableContext(2)]
		public virtual bool Received_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UAnimNotify.__Received_Notify_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x00024D4E File Offset: 0x00022F4E
		[NullableContext(1)]
		public virtual string GetNotifyName()
		{
			return FString.ToStringAndDeleteNativePtr(UAnimNotify.__GetNotifyName_Internal(base.NativePtr));
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00024D60 File Offset: 0x00022F60
		[NullableContext(1)]
		protected virtual string GetNotifyName_Implementation()
		{
			return FString.ToStringAndDeleteNativePtr(UAnimNotify.__GetNotifyName_Implementation_Internal(base.NativePtr));
		}

		// Token: 0x06001810 RID: 6160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Received_Notify_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06001811 RID: 6161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetNotifyName_Internal(IntPtr @this);

		// Token: 0x06001812 RID: 6162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetNotifyName_Implementation_Internal(IntPtr @this);

		// Token: 0x06001813 RID: 6163 RVA: 0x00024D72 File Offset: 0x00022F72
		static UAnimNotify()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotify");
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00024D80 File Offset: 0x00022F80
		protected UAnimNotify() : this(BuiltinUtils.AllocNativeUObject(UAnimNotify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00024DA8 File Offset: 0x00022FA8
		protected UAnimNotify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000796 RID: 1942
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotify";

		// Token: 0x04000797 RID: 1943
		private static IntPtr _ClassPtr;

		// Token: 0x04000798 RID: 1944
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000799 RID: 1945
		internal static int __PropertyOffset_NeedSimulate;

		// Token: 0x02000968 RID: 2408
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Received_Notify_FunctionParams
		{
			// Token: 0x04005894 RID: 22676
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04005895 RID: 22677
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04005896 RID: 22678
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000969 RID: 2409
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNotifyName_FunctionParams
		{
			// Token: 0x04005897 RID: 22679
			[FieldOffset(0)]
			public FString __Result;
		}
	}
}
