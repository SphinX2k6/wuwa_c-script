using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007CD RID: 1997
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AddDataLayerItem")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAddDataLayerItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006A7D RID: 27261 RVA: 0x0009979F File Offset: 0x0009799F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAddDataLayerItem._ScriptStructPtr != 0) ? FAddDataLayerItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AddDataLayerItem", ref FAddDataLayerItem._ScriptStructPtr);
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x06006A7E RID: 27262 RVA: 0x000997C4 File Offset: 0x000979C4
		// (set) Token: 0x06006A7F RID: 27263 RVA: 0x00099807 File Offset: 0x00097A07
		public TArray<FAddDataLayerSubItem> AddRegulars
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAddDataLayerSubItem> result;
				if ((result = this._AddRegulars) == null)
				{
					result = (this._AddRegulars = new TArray<FAddDataLayerSubItem>(base.NativePtr + (IntPtr)FAddDataLayerItem.__PropertyOffset_AddRegulars, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddRegulars.CopyAssign(value);
			}
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x06006A80 RID: 27264 RVA: 0x00099815 File Offset: 0x00097A15
		// (set) Token: 0x06006A81 RID: 27265 RVA: 0x00099825 File Offset: 0x00097A25
		public unsafe bool EnableRegexOne
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAddDataLayerItem.__PropertyOffset_EnableRegexOne) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAddDataLayerItem.__PropertyOffset_EnableRegexOne) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x06006A82 RID: 27266 RVA: 0x00099836 File Offset: 0x00097A36
		// (set) Token: 0x06006A83 RID: 27267 RVA: 0x0009984A File Offset: 0x00097A4A
		public unsafe string AddType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAddDataLayerItem.__PropertyOffset_AddType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAddDataLayerItem.__PropertyOffset_AddType)), value);
			}
		}

		// Token: 0x06006A84 RID: 27268 RVA: 0x0009985F File Offset: 0x00097A5F
		public FAddDataLayerItem()
		{
		}

		// Token: 0x06006A85 RID: 27269 RVA: 0x00099867 File Offset: 0x00097A67
		public FAddDataLayerItem(TArray<FAddDataLayerSubItem> AddRegulars, bool EnableRegexOne, string AddType)
		{
			this.AddRegulars = AddRegulars;
			this.EnableRegexOne = EnableRegexOne;
			this.AddType = AddType;
		}

		// Token: 0x06006A86 RID: 27270 RVA: 0x00099884 File Offset: 0x00097A84
		protected override IntPtr GetUStructPtr()
		{
			return FAddDataLayerItem.StaticStruct();
		}

		// Token: 0x06006A87 RID: 27271 RVA: 0x00099890 File Offset: 0x00097A90
		[NullableContext(2)]
		public FAddDataLayerItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x0009989A File Offset: 0x00097A9A
		public FAddDataLayerItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x000998A5 File Offset: 0x00097AA5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAddDataLayerItem(Pointer, false, true);
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x000998AF File Offset: 0x00097AAF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAddDataLayerItem(Pointer, MemoryOwner);
		}

		// Token: 0x04003344 RID: 13124
		public const string __ObjectPath = "/Script/Engine.AddDataLayerItem";

		// Token: 0x04003345 RID: 13125
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003346 RID: 13126
		internal static int __PropertyOffset_AddRegulars;

		// Token: 0x04003347 RID: 13127
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAddDataLayerSubItem> _AddRegulars;

		// Token: 0x04003348 RID: 13128
		internal static int __PropertyOffset_EnableRegexOne;

		// Token: 0x04003349 RID: 13129
		internal static int __PropertyOffset_AddType;
	}
}
