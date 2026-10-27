using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015C1 RID: 5569
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/json2struct.Json2struct_filter")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FJson2struct_filter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014149 RID: 82249 RVA: 0x001D7A03 File Offset: 0x001D5C03
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJson2struct_filter._ScriptStructPtr != 0) ? FJson2struct_filter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/json2struct.Json2struct_filter", ref FJson2struct_filter._ScriptStructPtr);
		}

		// Token: 0x17004EB0 RID: 20144
		// (get) Token: 0x0601414A RID: 82250 RVA: 0x001D7A28 File Offset: 0x001D5C28
		// (set) Token: 0x0601414B RID: 82251 RVA: 0x001D7A6B File Offset: 0x001D5C6B
		public TMap<string, EJson2StructFilterEnum> fields
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, EJson2StructFilterEnum> result;
				if ((result = this._fields) == null)
				{
					result = (this._fields = new TMap<string, EJson2StructFilterEnum>(base.NativePtr + (IntPtr)FJson2struct_filter.__PropertyOffset_fields, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.fields.CopyAssign(value);
			}
		}

		// Token: 0x0601414C RID: 82252 RVA: 0x001D7A79 File Offset: 0x001D5C79
		public FJson2struct_filter()
		{
		}

		// Token: 0x0601414D RID: 82253 RVA: 0x001D7A81 File Offset: 0x001D5C81
		public FJson2struct_filter(TMap<string, EJson2StructFilterEnum> fields)
		{
			this.fields = fields;
		}

		// Token: 0x0601414E RID: 82254 RVA: 0x001D7A90 File Offset: 0x001D5C90
		protected override IntPtr GetUStructPtr()
		{
			return FJson2struct_filter.StaticStruct();
		}

		// Token: 0x0601414F RID: 82255 RVA: 0x001D7A9C File Offset: 0x001D5C9C
		[NullableContext(2)]
		public FJson2struct_filter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014150 RID: 82256 RVA: 0x001D7AA6 File Offset: 0x001D5CA6
		public FJson2struct_filter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014151 RID: 82257 RVA: 0x001D7AB1 File Offset: 0x001D5CB1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJson2struct_filter(Pointer, false, true);
		}

		// Token: 0x06014152 RID: 82258 RVA: 0x001D7ABB File Offset: 0x001D5CBB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJson2struct_filter(Pointer, MemoryOwner);
		}

		// Token: 0x0400AEB6 RID: 44726
		public const string __ObjectPath = "/Script/json2struct.Json2struct_filter";

		// Token: 0x0400AEB7 RID: 44727
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AEB8 RID: 44728
		internal static int __PropertyOffset_fields;

		// Token: 0x0400AEB9 RID: 44729
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, EJson2StructFilterEnum> _fields;
	}
}
