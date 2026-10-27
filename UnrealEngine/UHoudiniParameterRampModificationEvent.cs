using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014F9 RID: 5369
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterRampModificationEvent")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UHoudiniParameterRampModificationEvent : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013766 RID: 79718 RVA: 0x001C9D49 File Offset: 0x001C7F49
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterRampModificationEvent._ClassPtr;
		}

		// Token: 0x06013767 RID: 79719 RVA: 0x001C9D58 File Offset: 0x001C7F58
		public UHoudiniParameterRampModificationEvent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterRampModificationEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013768 RID: 79720 RVA: 0x001C9D80 File Offset: 0x001C7F80
		[NullableContext(1)]
		public UHoudiniParameterRampModificationEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterRampModificationEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C10 RID: 19472
		// (get) Token: 0x06013769 RID: 79721 RVA: 0x001C9DB3 File Offset: 0x001C7FB3
		// (set) Token: 0x0601376A RID: 79722 RVA: 0x001C9DC3 File Offset: 0x001C7FC3
		public unsafe bool bIsInsertEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_bIsInsertEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_bIsInsertEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C11 RID: 19473
		// (get) Token: 0x0601376B RID: 79723 RVA: 0x001C9DD4 File Offset: 0x001C7FD4
		// (set) Token: 0x0601376C RID: 79724 RVA: 0x001C9DE4 File Offset: 0x001C7FE4
		public unsafe bool bIsFloatRamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_bIsFloatRamp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_bIsFloatRamp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C12 RID: 19474
		// (get) Token: 0x0601376D RID: 79725 RVA: 0x001C9DF5 File Offset: 0x001C7FF5
		// (set) Token: 0x0601376E RID: 79726 RVA: 0x001C9E05 File Offset: 0x001C8005
		public unsafe int DeleteInstanceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_DeleteInstanceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_DeleteInstanceIndex) = value;
			}
		}

		// Token: 0x17004C13 RID: 19475
		// (get) Token: 0x0601376F RID: 79727 RVA: 0x001C9E16 File Offset: 0x001C8016
		// (set) Token: 0x06013770 RID: 79728 RVA: 0x001C9E26 File Offset: 0x001C8026
		public unsafe float InsertPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_InsertPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_InsertPosition) = value;
			}
		}

		// Token: 0x17004C14 RID: 19476
		// (get) Token: 0x06013771 RID: 79729 RVA: 0x001C9E37 File Offset: 0x001C8037
		// (set) Token: 0x06013772 RID: 79730 RVA: 0x001C9E47 File Offset: 0x001C8047
		public unsafe float InsertFloat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_InsertFloat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_InsertFloat) = value;
			}
		}

		// Token: 0x17004C15 RID: 19477
		// (get) Token: 0x06013773 RID: 79731 RVA: 0x001C9E58 File Offset: 0x001C8058
		// (set) Token: 0x06013774 RID: 79732 RVA: 0x001C9E6C File Offset: 0x001C806C
		public unsafe FLinearColor InsertColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_InsertColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_InsertColor) = value;
			}
		}

		// Token: 0x17004C16 RID: 19478
		// (get) Token: 0x06013775 RID: 79733 RVA: 0x001C9E81 File Offset: 0x001C8081
		// (set) Token: 0x06013776 RID: 79734 RVA: 0x001C9E91 File Offset: 0x001C8091
		public unsafe EHoudiniRampInterpolationType InsertInterpolation
		{
			get
			{
				return (EHoudiniRampInterpolationType)(*(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_InsertInterpolation));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampModificationEvent.__PropertyOffset_InsertInterpolation) = (byte)value;
			}
		}

		// Token: 0x06013777 RID: 79735 RVA: 0x001C9EA2 File Offset: 0x001C80A2
		static UHoudiniParameterRampModificationEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterRampModificationEvent");
		}

		// Token: 0x06013778 RID: 79736 RVA: 0x001C9EB0 File Offset: 0x001C80B0
		protected UHoudiniParameterRampModificationEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A854 RID: 43092
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterRampModificationEvent";

		// Token: 0x0400A855 RID: 43093
		private static IntPtr _ClassPtr;

		// Token: 0x0400A856 RID: 43094
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A857 RID: 43095
		internal static int __PropertyOffset_bIsInsertEvent;

		// Token: 0x0400A858 RID: 43096
		internal static int __PropertyOffset_bIsFloatRamp;

		// Token: 0x0400A859 RID: 43097
		internal static int __PropertyOffset_DeleteInstanceIndex;

		// Token: 0x0400A85A RID: 43098
		internal static int __PropertyOffset_InsertPosition;

		// Token: 0x0400A85B RID: 43099
		internal static int __PropertyOffset_InsertFloat;

		// Token: 0x0400A85C RID: 43100
		internal static int __PropertyOffset_InsertColor;

		// Token: 0x0400A85D RID: 43101
		internal static int __PropertyOffset_InsertInterpolation;
	}
}
