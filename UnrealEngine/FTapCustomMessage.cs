using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028E3 RID: 10467
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapCustomMessage")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FTapCustomMessage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026D3A RID: 159034 RVA: 0x003B3700 File Offset: 0x003B1900
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTapCustomMessage._ScriptStructPtr != 0) ? FTapCustomMessage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TapCustomMessage", ref FTapCustomMessage._ScriptStructPtr);
		}

		// Token: 0x17009591 RID: 38289
		// (get) Token: 0x06026D3B RID: 159035 RVA: 0x003B3724 File Offset: 0x003B1924
		// (set) Token: 0x06026D3C RID: 159036 RVA: 0x003B3738 File Offset: 0x003B1938
		public unsafe string MessageName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTapCustomMessage.__PropertyOffset_MessageName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTapCustomMessage.__PropertyOffset_MessageName)), value);
			}
		}

		// Token: 0x17009592 RID: 38290
		// (get) Token: 0x06026D3D RID: 159037 RVA: 0x003B374D File Offset: 0x003B194D
		// (set) Token: 0x06026D3E RID: 159038 RVA: 0x003B3761 File Offset: 0x003B1961
		public unsafe string MessageContent
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTapCustomMessage.__PropertyOffset_MessageContent)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTapCustomMessage.__PropertyOffset_MessageContent)), value);
			}
		}

		// Token: 0x06026D3F RID: 159039 RVA: 0x003B3776 File Offset: 0x003B1976
		public FTapCustomMessage()
		{
		}

		// Token: 0x06026D40 RID: 159040 RVA: 0x003B377E File Offset: 0x003B197E
		public FTapCustomMessage(string MessageName, string MessageContent)
		{
			this.MessageName = MessageName;
			this.MessageContent = MessageContent;
		}

		// Token: 0x06026D41 RID: 159041 RVA: 0x003B3794 File Offset: 0x003B1994
		protected override IntPtr GetUStructPtr()
		{
			return FTapCustomMessage.StaticStruct();
		}

		// Token: 0x06026D42 RID: 159042 RVA: 0x003B37A0 File Offset: 0x003B19A0
		[NullableContext(2)]
		public FTapCustomMessage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026D43 RID: 159043 RVA: 0x003B37AA File Offset: 0x003B19AA
		public FTapCustomMessage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026D44 RID: 159044 RVA: 0x003B37B5 File Offset: 0x003B19B5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTapCustomMessage(Pointer, false, true);
		}

		// Token: 0x06026D45 RID: 159045 RVA: 0x003B37BF File Offset: 0x003B19BF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTapCustomMessage(Pointer, MemoryOwner);
		}

		// Token: 0x0401550D RID: 87309
		public const string __ObjectPath = "/Script/TapCommon.TapCustomMessage";

		// Token: 0x0401550E RID: 87310
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401550F RID: 87311
		internal static int __PropertyOffset_MessageName;

		// Token: 0x04015510 RID: 87312
		internal static int __PropertyOffset_MessageContent;
	}
}
