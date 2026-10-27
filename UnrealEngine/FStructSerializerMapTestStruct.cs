using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002720 RID: 10016
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Serialization.StructSerializerMapTestStruct")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 320)]
	public class FStructSerializerMapTestStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060251C4 RID: 152004 RVA: 0x0036F54B File Offset: 0x0036D74B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStructSerializerMapTestStruct._ScriptStructPtr != 0) ? FStructSerializerMapTestStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Serialization.StructSerializerMapTestStruct", ref FStructSerializerMapTestStruct._ScriptStructPtr);
		}

		// Token: 0x17008F33 RID: 36659
		// (get) Token: 0x060251C5 RID: 152005 RVA: 0x0036F570 File Offset: 0x0036D770
		// (set) Token: 0x060251C6 RID: 152006 RVA: 0x0036F5B3 File Offset: 0x0036D7B3
		public TMap<int, string> IntToStr
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, string> result;
				if ((result = this._IntToStr) == null)
				{
					result = (this._IntToStr = new TMap<int, string>(base.NativePtr + (IntPtr)FStructSerializerMapTestStruct.__PropertyOffset_IntToStr, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IntToStr.CopyAssign(value);
			}
		}

		// Token: 0x17008F34 RID: 36660
		// (get) Token: 0x060251C7 RID: 152007 RVA: 0x0036F5C4 File Offset: 0x0036D7C4
		// (set) Token: 0x060251C8 RID: 152008 RVA: 0x0036F607 File Offset: 0x0036D807
		public TMap<string, string> StrToStr
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._StrToStr) == null)
				{
					result = (this._StrToStr = new TMap<string, string>(base.NativePtr + (IntPtr)FStructSerializerMapTestStruct.__PropertyOffset_StrToStr, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StrToStr.CopyAssign(value);
			}
		}

		// Token: 0x17008F35 RID: 36661
		// (get) Token: 0x060251C9 RID: 152009 RVA: 0x0036F618 File Offset: 0x0036D818
		// (set) Token: 0x060251CA RID: 152010 RVA: 0x0036F65B File Offset: 0x0036D85B
		public TMap<string, FVector> StrToVec
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FVector> result;
				if ((result = this._StrToVec) == null)
				{
					result = (this._StrToVec = new TMap<string, FVector>(base.NativePtr + (IntPtr)FStructSerializerMapTestStruct.__PropertyOffset_StrToVec, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StrToVec.CopyAssign(value);
			}
		}

		// Token: 0x17008F36 RID: 36662
		// (get) Token: 0x060251CB RID: 152011 RVA: 0x0036F66C File Offset: 0x0036D86C
		// (set) Token: 0x060251CC RID: 152012 RVA: 0x0036F6AF File Offset: 0x0036D8AF
		public TMap<string, FStructSerializerBuiltinTestStruct> StrToStruct
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FStructSerializerBuiltinTestStruct> result;
				if ((result = this._StrToStruct) == null)
				{
					result = (this._StrToStruct = new TMap<string, FStructSerializerBuiltinTestStruct>(base.NativePtr + (IntPtr)FStructSerializerMapTestStruct.__PropertyOffset_StrToStruct, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StrToStruct.CopyAssign(value);
			}
		}

		// Token: 0x060251CD RID: 152013 RVA: 0x0036F6BD File Offset: 0x0036D8BD
		public FStructSerializerMapTestStruct()
		{
		}

		// Token: 0x060251CE RID: 152014 RVA: 0x0036F6C5 File Offset: 0x0036D8C5
		public FStructSerializerMapTestStruct(TMap<int, string> IntToStr, TMap<string, string> StrToStr, TMap<string, FVector> StrToVec, TMap<string, FStructSerializerBuiltinTestStruct> StrToStruct)
		{
			this.IntToStr = IntToStr;
			this.StrToStr = StrToStr;
			this.StrToVec = StrToVec;
			this.StrToStruct = StrToStruct;
		}

		// Token: 0x060251CF RID: 152015 RVA: 0x0036F6EA File Offset: 0x0036D8EA
		protected override IntPtr GetUStructPtr()
		{
			return FStructSerializerMapTestStruct.StaticStruct();
		}

		// Token: 0x060251D0 RID: 152016 RVA: 0x0036F6F6 File Offset: 0x0036D8F6
		[NullableContext(2)]
		public FStructSerializerMapTestStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060251D1 RID: 152017 RVA: 0x0036F700 File Offset: 0x0036D900
		public FStructSerializerMapTestStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060251D2 RID: 152018 RVA: 0x0036F70B File Offset: 0x0036D90B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStructSerializerMapTestStruct(Pointer, false, true);
		}

		// Token: 0x060251D3 RID: 152019 RVA: 0x0036F715 File Offset: 0x0036D915
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStructSerializerMapTestStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04013FF8 RID: 81912
		public const string __ObjectPath = "/Script/Serialization.StructSerializerMapTestStruct";

		// Token: 0x04013FF9 RID: 81913
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013FFA RID: 81914
		internal static int __PropertyOffset_IntToStr;

		// Token: 0x04013FFB RID: 81915
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, string> _IntToStr;

		// Token: 0x04013FFC RID: 81916
		internal static int __PropertyOffset_StrToStr;

		// Token: 0x04013FFD RID: 81917
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _StrToStr;

		// Token: 0x04013FFE RID: 81918
		internal static int __PropertyOffset_StrToVec;

		// Token: 0x04013FFF RID: 81919
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FVector> _StrToVec;

		// Token: 0x04014000 RID: 81920
		internal static int __PropertyOffset_StrToStruct;

		// Token: 0x04014001 RID: 81921
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FStructSerializerBuiltinTestStruct> _StrToStruct;
	}
}
