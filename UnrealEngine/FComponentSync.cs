using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000964 RID: 2404
	[UnrealObjectPath("/Script/Engine.ComponentSync")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FComponentSync : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060087CC RID: 34764 RVA: 0x000C27D2 File Offset: 0x000C09D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FComponentSync._ScriptStructPtr != 0) ? FComponentSync._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ComponentSync", ref FComponentSync._ScriptStructPtr);
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x060087CD RID: 34765 RVA: 0x000C27F6 File Offset: 0x000C09F6
		// (set) Token: 0x060087CE RID: 34766 RVA: 0x000C280A File Offset: 0x000C0A0A
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentSync.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentSync.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x060087CF RID: 34767 RVA: 0x000C281F File Offset: 0x000C0A1F
		// (set) Token: 0x060087D0 RID: 34768 RVA: 0x000C282F File Offset: 0x000C0A2F
		public unsafe ESyncOption SyncOption
		{
			get
			{
				return (ESyncOption)(*(base.NativePtr + (IntPtr)FComponentSync.__PropertyOffset_SyncOption));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentSync.__PropertyOffset_SyncOption) = (byte)value;
			}
		}

		// Token: 0x060087D1 RID: 34769 RVA: 0x000C2840 File Offset: 0x000C0A40
		public FComponentSync()
		{
		}

		// Token: 0x060087D2 RID: 34770 RVA: 0x000C2848 File Offset: 0x000C0A48
		public FComponentSync(FName Name, ESyncOption SyncOption)
		{
			this.Name = Name;
			this.SyncOption = SyncOption;
		}

		// Token: 0x060087D3 RID: 34771 RVA: 0x000C285E File Offset: 0x000C0A5E
		protected override IntPtr GetUStructPtr()
		{
			return FComponentSync.StaticStruct();
		}

		// Token: 0x060087D4 RID: 34772 RVA: 0x000C286A File Offset: 0x000C0A6A
		[NullableContext(2)]
		public FComponentSync(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087D5 RID: 34773 RVA: 0x000C2874 File Offset: 0x000C0A74
		public FComponentSync(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087D6 RID: 34774 RVA: 0x000C287F File Offset: 0x000C0A7F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FComponentSync(Pointer, false, true);
		}

		// Token: 0x060087D7 RID: 34775 RVA: 0x000C2889 File Offset: 0x000C0A89
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FComponentSync(Pointer, MemoryOwner);
		}

		// Token: 0x0400408D RID: 16525
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentSync";

		// Token: 0x0400408E RID: 16526
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400408F RID: 16527
		internal static int __PropertyOffset_Name;

		// Token: 0x04004090 RID: 16528
		internal static int __PropertyOffset_SyncOption;
	}
}
