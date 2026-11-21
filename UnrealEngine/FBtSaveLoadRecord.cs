using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002D9 RID: 729
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAI.BtSaveLoadRecord")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBtSaveLoadRecord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004EBE RID: 20158 RVA: 0x0006E048 File Offset: 0x0006C248
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBtSaveLoadRecord._ScriptStructPtr != 0) ? FBtSaveLoadRecord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAI.BtSaveLoadRecord", ref FBtSaveLoadRecord._ScriptStructPtr);
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06004EBF RID: 20159 RVA: 0x0006E06C File Offset: 0x0006C26C
		// (set) Token: 0x06004EC0 RID: 20160 RVA: 0x0006E0AF File Offset: 0x0006C2AF
		public TArray<FBtSaveLoadRecordItem> Items
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBtSaveLoadRecordItem> result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new TArray<FBtSaveLoadRecordItem>(base.NativePtr + (IntPtr)FBtSaveLoadRecord.__PropertyOffset_Items, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Items.CopyAssign(value);
			}
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x0006E0BD File Offset: 0x0006C2BD
		public FBtSaveLoadRecord()
		{
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x0006E0C5 File Offset: 0x0006C2C5
		protected override IntPtr GetUStructPtr()
		{
			return FBtSaveLoadRecord.StaticStruct();
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x0006E0D1 File Offset: 0x0006C2D1
		[NullableContext(2)]
		public FBtSaveLoadRecord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x0006E0DB File Offset: 0x0006C2DB
		public FBtSaveLoadRecord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x0006E0E6 File Offset: 0x0006C2E6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBtSaveLoadRecord(Pointer, false, true);
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x0006E0F0 File Offset: 0x0006C2F0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBtSaveLoadRecord(Pointer, MemoryOwner);
		}

		// Token: 0x04001F7E RID: 8062
		public const string __ObjectPath = "/Script/KuroAI.BtSaveLoadRecord";

		// Token: 0x04001F7F RID: 8063
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F80 RID: 8064
		internal static int __PropertyOffset_Items;

		// Token: 0x04001F81 RID: 8065
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBtSaveLoadRecordItem> _Items;
	}
}
