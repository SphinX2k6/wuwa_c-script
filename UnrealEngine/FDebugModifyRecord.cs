using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019D6 RID: 6614
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMovement.DebugModifyRecord")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FDebugModifyRecord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060188FE RID: 100606 RVA: 0x00242C34 File Offset: 0x00240E34
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDebugModifyRecord._ScriptStructPtr != 0) ? FDebugModifyRecord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMovement.DebugModifyRecord", ref FDebugModifyRecord._ScriptStructPtr);
		}

		// Token: 0x170061E6 RID: 25062
		// (get) Token: 0x060188FF RID: 100607 RVA: 0x00242C58 File Offset: 0x00240E58
		// (set) Token: 0x06018900 RID: 100608 RVA: 0x00242C6C File Offset: 0x00240E6C
		public unsafe string Context
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDebugModifyRecord.__PropertyOffset_Context)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDebugModifyRecord.__PropertyOffset_Context)), value);
			}
		}

		// Token: 0x170061E7 RID: 25063
		// (get) Token: 0x06018901 RID: 100609 RVA: 0x00242C84 File Offset: 0x00240E84
		// (set) Token: 0x06018902 RID: 100610 RVA: 0x00242CC7 File Offset: 0x00240EC7
		public FBaseRecord Record
		{
			get
			{
				base.FastCheckIsValid();
				FBaseRecord result;
				if ((result = this._Record) == null)
				{
					result = (this._Record = new FBaseRecord(base.NativePtr + (IntPtr)FDebugModifyRecord.__PropertyOffset_Record, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBaseRecord.StaticStruct(), base.NativePtr + (IntPtr)FDebugModifyRecord.__PropertyOffset_Record, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06018903 RID: 100611 RVA: 0x00242CE8 File Offset: 0x00240EE8
		public FDebugModifyRecord()
		{
		}

		// Token: 0x06018904 RID: 100612 RVA: 0x00242CF0 File Offset: 0x00240EF0
		public FDebugModifyRecord(string Context, FBaseRecord Record)
		{
			this.Context = Context;
			this.Record = Record;
		}

		// Token: 0x06018905 RID: 100613 RVA: 0x00242D06 File Offset: 0x00240F06
		protected override IntPtr GetUStructPtr()
		{
			return FDebugModifyRecord.StaticStruct();
		}

		// Token: 0x06018906 RID: 100614 RVA: 0x00242D12 File Offset: 0x00240F12
		[NullableContext(2)]
		public FDebugModifyRecord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018907 RID: 100615 RVA: 0x00242D1C File Offset: 0x00240F1C
		public FDebugModifyRecord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018908 RID: 100616 RVA: 0x00242D27 File Offset: 0x00240F27
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDebugModifyRecord(Pointer, false, true);
		}

		// Token: 0x06018909 RID: 100617 RVA: 0x00242D31 File Offset: 0x00240F31
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDebugModifyRecord(Pointer, MemoryOwner);
		}

		// Token: 0x0400D451 RID: 54353
		public const string __ObjectPath = "/Script/KuroMovement.DebugModifyRecord";

		// Token: 0x0400D452 RID: 54354
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D453 RID: 54355
		internal static int __PropertyOffset_Context;

		// Token: 0x0400D454 RID: 54356
		internal static int __PropertyOffset_Record;

		// Token: 0x0400D455 RID: 54357
		[Nullable(2)]
		private FBaseRecord _Record;
	}
}
