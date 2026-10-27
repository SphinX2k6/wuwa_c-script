using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C19 RID: 3097
	[UnrealObjectPath("/Script/Engine.HardwareCursorReference")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FHardwareCursorReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009C77 RID: 40055 RVA: 0x000DE83B File Offset: 0x000DCA3B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHardwareCursorReference._ScriptStructPtr != 0) ? FHardwareCursorReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HardwareCursorReference", ref FHardwareCursorReference._ScriptStructPtr);
		}

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x06009C78 RID: 40056 RVA: 0x000DE85F File Offset: 0x000DCA5F
		// (set) Token: 0x06009C79 RID: 40057 RVA: 0x000DE873 File Offset: 0x000DCA73
		public unsafe FName CursorPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHardwareCursorReference.__PropertyOffset_CursorPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHardwareCursorReference.__PropertyOffset_CursorPath) = value;
			}
		}

		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x06009C7A RID: 40058 RVA: 0x000DE888 File Offset: 0x000DCA88
		// (set) Token: 0x06009C7B RID: 40059 RVA: 0x000DE89C File Offset: 0x000DCA9C
		public unsafe FVector2D HotSpot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHardwareCursorReference.__PropertyOffset_HotSpot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHardwareCursorReference.__PropertyOffset_HotSpot) = value;
			}
		}

		// Token: 0x06009C7C RID: 40060 RVA: 0x000DE8B1 File Offset: 0x000DCAB1
		public FHardwareCursorReference()
		{
		}

		// Token: 0x06009C7D RID: 40061 RVA: 0x000DE8B9 File Offset: 0x000DCAB9
		public FHardwareCursorReference(FName CursorPath, FVector2D HotSpot)
		{
			this.CursorPath = CursorPath;
			this.HotSpot = HotSpot;
		}

		// Token: 0x06009C7E RID: 40062 RVA: 0x000DE8CF File Offset: 0x000DCACF
		protected override IntPtr GetUStructPtr()
		{
			return FHardwareCursorReference.StaticStruct();
		}

		// Token: 0x06009C7F RID: 40063 RVA: 0x000DE8DB File Offset: 0x000DCADB
		[NullableContext(2)]
		public FHardwareCursorReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009C80 RID: 40064 RVA: 0x000DE8E5 File Offset: 0x000DCAE5
		public FHardwareCursorReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009C81 RID: 40065 RVA: 0x000DE8F0 File Offset: 0x000DCAF0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHardwareCursorReference(Pointer, false, true);
		}

		// Token: 0x06009C82 RID: 40066 RVA: 0x000DE8FA File Offset: 0x000DCAFA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHardwareCursorReference(Pointer, MemoryOwner);
		}

		// Token: 0x0400565D RID: 22109
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.HardwareCursorReference";

		// Token: 0x0400565E RID: 22110
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400565F RID: 22111
		internal static int __PropertyOffset_CursorPath;

		// Token: 0x04005660 RID: 22112
		internal static int __PropertyOffset_HotSpot;
	}
}
