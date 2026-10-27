using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015F9 RID: 5625
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAI.BtSaveLoadRecord")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBtSaveLoadRecord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060143FB RID: 82939 RVA: 0x001DBBA6 File Offset: 0x001D9DA6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBtSaveLoadRecord._ScriptStructPtr != 0) ? FBtSaveLoadRecord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAI.BtSaveLoadRecord", ref FBtSaveLoadRecord._ScriptStructPtr);
		}

		// Token: 0x17004F55 RID: 20309
		// (get) Token: 0x060143FC RID: 82940 RVA: 0x001DBBCC File Offset: 0x001D9DCC
		// (set) Token: 0x060143FD RID: 82941 RVA: 0x001DBC0F File Offset: 0x001D9E0F
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

		// Token: 0x060143FE RID: 82942 RVA: 0x001DBC1D File Offset: 0x001D9E1D
		public FBtSaveLoadRecord()
		{
		}

		// Token: 0x060143FF RID: 82943 RVA: 0x001DBC25 File Offset: 0x001D9E25
		public FBtSaveLoadRecord(TArray<FBtSaveLoadRecordItem> Items)
		{
			this.Items = Items;
		}

		// Token: 0x06014400 RID: 82944 RVA: 0x001DBC34 File Offset: 0x001D9E34
		protected override IntPtr GetUStructPtr()
		{
			return FBtSaveLoadRecord.StaticStruct();
		}

		// Token: 0x06014401 RID: 82945 RVA: 0x001DBC40 File Offset: 0x001D9E40
		[NullableContext(2)]
		public FBtSaveLoadRecord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014402 RID: 82946 RVA: 0x001DBC4A File Offset: 0x001D9E4A
		public FBtSaveLoadRecord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014403 RID: 82947 RVA: 0x001DBC55 File Offset: 0x001D9E55
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBtSaveLoadRecord(Pointer, false, true);
		}

		// Token: 0x06014404 RID: 82948 RVA: 0x001DBC5F File Offset: 0x001D9E5F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBtSaveLoadRecord(Pointer, MemoryOwner);
		}

		// Token: 0x0400B043 RID: 45123
		public const string __ObjectPath = "/Script/KuroAI.BtSaveLoadRecord";

		// Token: 0x0400B044 RID: 45124
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B045 RID: 45125
		internal static int __PropertyOffset_Items;

		// Token: 0x0400B046 RID: 45126
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBtSaveLoadRecordItem> _Items;
	}
}
