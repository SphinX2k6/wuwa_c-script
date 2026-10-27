using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002723 RID: 10019
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Serialization.StructSerializerSetTestStruct")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 320)]
	public class FStructSerializerSetTestStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025208 RID: 152072 RVA: 0x0036FBCC File Offset: 0x0036DDCC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStructSerializerSetTestStruct._ScriptStructPtr != 0) ? FStructSerializerSetTestStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Serialization.StructSerializerSetTestStruct", ref FStructSerializerSetTestStruct._ScriptStructPtr);
		}

		// Token: 0x17008F49 RID: 36681
		// (get) Token: 0x06025209 RID: 152073 RVA: 0x0036FBF0 File Offset: 0x0036DDF0
		// (set) Token: 0x0602520A RID: 152074 RVA: 0x0036FC33 File Offset: 0x0036DE33
		public TSet<string> StrSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._StrSet) == null)
				{
					result = (this._StrSet = new TSet<string>(base.NativePtr + (IntPtr)FStructSerializerSetTestStruct.__PropertyOffset_StrSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StrSet.CopyAssign(value);
			}
		}

		// Token: 0x17008F4A RID: 36682
		// (get) Token: 0x0602520B RID: 152075 RVA: 0x0036FC44 File Offset: 0x0036DE44
		// (set) Token: 0x0602520C RID: 152076 RVA: 0x0036FC87 File Offset: 0x0036DE87
		public TSet<int> IntSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._IntSet) == null)
				{
					result = (this._IntSet = new TSet<int>(base.NativePtr + (IntPtr)FStructSerializerSetTestStruct.__PropertyOffset_IntSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IntSet.CopyAssign(value);
			}
		}

		// Token: 0x17008F4B RID: 36683
		// (get) Token: 0x0602520D RID: 152077 RVA: 0x0036FC98 File Offset: 0x0036DE98
		// (set) Token: 0x0602520E RID: 152078 RVA: 0x0036FCDB File Offset: 0x0036DEDB
		public TSet<FName> NameSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._NameSet) == null)
				{
					result = (this._NameSet = new TSet<FName>(base.NativePtr + (IntPtr)FStructSerializerSetTestStruct.__PropertyOffset_NameSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NameSet.CopyAssign(value);
			}
		}

		// Token: 0x17008F4C RID: 36684
		// (get) Token: 0x0602520F RID: 152079 RVA: 0x0036FCEC File Offset: 0x0036DEEC
		// (set) Token: 0x06025210 RID: 152080 RVA: 0x0036FD2F File Offset: 0x0036DF2F
		public TSet<FStructSerializerBuiltinTestStruct> StructSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FStructSerializerBuiltinTestStruct> result;
				if ((result = this._StructSet) == null)
				{
					result = (this._StructSet = new TSet<FStructSerializerBuiltinTestStruct>(base.NativePtr + (IntPtr)FStructSerializerSetTestStruct.__PropertyOffset_StructSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StructSet.CopyAssign(value);
			}
		}

		// Token: 0x06025211 RID: 152081 RVA: 0x0036FD3D File Offset: 0x0036DF3D
		public FStructSerializerSetTestStruct()
		{
		}

		// Token: 0x06025212 RID: 152082 RVA: 0x0036FD45 File Offset: 0x0036DF45
		public FStructSerializerSetTestStruct(TSet<string> StrSet, TSet<int> IntSet, TSet<FName> NameSet, TSet<FStructSerializerBuiltinTestStruct> StructSet)
		{
			this.StrSet = StrSet;
			this.IntSet = IntSet;
			this.NameSet = NameSet;
			this.StructSet = StructSet;
		}

		// Token: 0x06025213 RID: 152083 RVA: 0x0036FD6A File Offset: 0x0036DF6A
		protected override IntPtr GetUStructPtr()
		{
			return FStructSerializerSetTestStruct.StaticStruct();
		}

		// Token: 0x06025214 RID: 152084 RVA: 0x0036FD76 File Offset: 0x0036DF76
		[NullableContext(2)]
		public FStructSerializerSetTestStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025215 RID: 152085 RVA: 0x0036FD80 File Offset: 0x0036DF80
		public FStructSerializerSetTestStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025216 RID: 152086 RVA: 0x0036FD8B File Offset: 0x0036DF8B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStructSerializerSetTestStruct(Pointer, false, true);
		}

		// Token: 0x06025217 RID: 152087 RVA: 0x0036FD95 File Offset: 0x0036DF95
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStructSerializerSetTestStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0401401A RID: 81946
		public const string __ObjectPath = "/Script/Serialization.StructSerializerSetTestStruct";

		// Token: 0x0401401B RID: 81947
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401401C RID: 81948
		internal static int __PropertyOffset_StrSet;

		// Token: 0x0401401D RID: 81949
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _StrSet;

		// Token: 0x0401401E RID: 81950
		internal static int __PropertyOffset_IntSet;

		// Token: 0x0401401F RID: 81951
		[Nullable(2)]
		private TSet<int> _IntSet;

		// Token: 0x04014020 RID: 81952
		internal static int __PropertyOffset_NameSet;

		// Token: 0x04014021 RID: 81953
		[Nullable(2)]
		private TSet<FName> _NameSet;

		// Token: 0x04014022 RID: 81954
		internal static int __PropertyOffset_StructSet;

		// Token: 0x04014023 RID: 81955
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FStructSerializerBuiltinTestStruct> _StructSet;
	}
}
