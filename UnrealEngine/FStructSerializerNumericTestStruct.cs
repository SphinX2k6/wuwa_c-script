using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002721 RID: 10017
	[UnrealObjectPath("/Script/Serialization.StructSerializerNumericTestStruct")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FStructSerializerNumericTestStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060251D4 RID: 152020 RVA: 0x0036F71E File Offset: 0x0036D91E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStructSerializerNumericTestStruct._ScriptStructPtr != 0) ? FStructSerializerNumericTestStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Serialization.StructSerializerNumericTestStruct", ref FStructSerializerNumericTestStruct._ScriptStructPtr);
		}

		// Token: 0x17008F37 RID: 36663
		// (get) Token: 0x060251D5 RID: 152021 RVA: 0x0036F742 File Offset: 0x0036D942
		// (set) Token: 0x060251D6 RID: 152022 RVA: 0x0036F752 File Offset: 0x0036D952
		public unsafe sbyte Int8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_Int8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_Int8) = (byte)value;
			}
		}

		// Token: 0x17008F38 RID: 36664
		// (get) Token: 0x060251D7 RID: 152023 RVA: 0x0036F763 File Offset: 0x0036D963
		// (set) Token: 0x060251D8 RID: 152024 RVA: 0x0036F773 File Offset: 0x0036D973
		public unsafe short Int16
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_Int16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_Int16) = value;
			}
		}

		// Token: 0x17008F39 RID: 36665
		// (get) Token: 0x060251D9 RID: 152025 RVA: 0x0036F784 File Offset: 0x0036D984
		// (set) Token: 0x060251DA RID: 152026 RVA: 0x0036F794 File Offset: 0x0036D994
		public unsafe int Int32
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_Int32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_Int32) = value;
			}
		}

		// Token: 0x17008F3A RID: 36666
		// (get) Token: 0x060251DB RID: 152027 RVA: 0x0036F7A5 File Offset: 0x0036D9A5
		// (set) Token: 0x060251DC RID: 152028 RVA: 0x0036F7B5 File Offset: 0x0036D9B5
		public unsafe long Int64
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_Int64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_Int64) = value;
			}
		}

		// Token: 0x17008F3B RID: 36667
		// (get) Token: 0x060251DD RID: 152029 RVA: 0x0036F7C6 File Offset: 0x0036D9C6
		// (set) Token: 0x060251DE RID: 152030 RVA: 0x0036F7D6 File Offset: 0x0036D9D6
		public unsafe byte UInt8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_UInt8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_UInt8) = value;
			}
		}

		// Token: 0x17008F3C RID: 36668
		// (get) Token: 0x060251DF RID: 152031 RVA: 0x0036F7E7 File Offset: 0x0036D9E7
		// (set) Token: 0x060251E0 RID: 152032 RVA: 0x0036F7F7 File Offset: 0x0036D9F7
		public unsafe ushort UInt16
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_UInt16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_UInt16) = (short)value;
			}
		}

		// Token: 0x17008F3D RID: 36669
		// (get) Token: 0x060251E1 RID: 152033 RVA: 0x0036F808 File Offset: 0x0036DA08
		// (set) Token: 0x060251E2 RID: 152034 RVA: 0x0036F818 File Offset: 0x0036DA18
		public unsafe uint UInt32
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_UInt32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_UInt32) = (int)value;
			}
		}

		// Token: 0x17008F3E RID: 36670
		// (get) Token: 0x060251E3 RID: 152035 RVA: 0x0036F829 File Offset: 0x0036DA29
		// (set) Token: 0x060251E4 RID: 152036 RVA: 0x0036F839 File Offset: 0x0036DA39
		public unsafe ulong UInt64
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_UInt64));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_UInt64) = (long)value;
			}
		}

		// Token: 0x17008F3F RID: 36671
		// (get) Token: 0x060251E5 RID: 152037 RVA: 0x0036F84A File Offset: 0x0036DA4A
		// (set) Token: 0x060251E6 RID: 152038 RVA: 0x0036F85A File Offset: 0x0036DA5A
		public unsafe float Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_Float);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_Float) = value;
			}
		}

		// Token: 0x17008F40 RID: 36672
		// (get) Token: 0x060251E7 RID: 152039 RVA: 0x0036F86B File Offset: 0x0036DA6B
		// (set) Token: 0x060251E8 RID: 152040 RVA: 0x0036F87B File Offset: 0x0036DA7B
		public unsafe double Double
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_Double);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerNumericTestStruct.__PropertyOffset_Double) = value;
			}
		}

		// Token: 0x060251E9 RID: 152041 RVA: 0x0036F88C File Offset: 0x0036DA8C
		public FStructSerializerNumericTestStruct()
		{
		}

		// Token: 0x060251EA RID: 152042 RVA: 0x0036F894 File Offset: 0x0036DA94
		public FStructSerializerNumericTestStruct(sbyte Int8, short Int16, int Int32, long Int64, byte UInt8, ushort UInt16, uint UInt32, ulong UInt64, float Float, double Double)
		{
			this.Int8 = Int8;
			this.Int16 = Int16;
			this.Int32 = Int32;
			this.Int64 = Int64;
			this.UInt8 = UInt8;
			this.UInt16 = UInt16;
			this.UInt32 = UInt32;
			this.UInt64 = UInt64;
			this.Float = Float;
			this.Double = Double;
		}

		// Token: 0x060251EB RID: 152043 RVA: 0x0036F8F4 File Offset: 0x0036DAF4
		protected override IntPtr GetUStructPtr()
		{
			return FStructSerializerNumericTestStruct.StaticStruct();
		}

		// Token: 0x060251EC RID: 152044 RVA: 0x0036F900 File Offset: 0x0036DB00
		[NullableContext(2)]
		public FStructSerializerNumericTestStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060251ED RID: 152045 RVA: 0x0036F90A File Offset: 0x0036DB0A
		public FStructSerializerNumericTestStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060251EE RID: 152046 RVA: 0x0036F915 File Offset: 0x0036DB15
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStructSerializerNumericTestStruct(Pointer, false, true);
		}

		// Token: 0x060251EF RID: 152047 RVA: 0x0036F91F File Offset: 0x0036DB1F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStructSerializerNumericTestStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04014002 RID: 81922
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Serialization.StructSerializerNumericTestStruct";

		// Token: 0x04014003 RID: 81923
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014004 RID: 81924
		internal static int __PropertyOffset_Int8;

		// Token: 0x04014005 RID: 81925
		internal static int __PropertyOffset_Int16;

		// Token: 0x04014006 RID: 81926
		internal static int __PropertyOffset_Int32;

		// Token: 0x04014007 RID: 81927
		internal static int __PropertyOffset_Int64;

		// Token: 0x04014008 RID: 81928
		internal static int __PropertyOffset_UInt8;

		// Token: 0x04014009 RID: 81929
		internal static int __PropertyOffset_UInt16;

		// Token: 0x0401400A RID: 81930
		internal static int __PropertyOffset_UInt32;

		// Token: 0x0401400B RID: 81931
		internal static int __PropertyOffset_UInt64;

		// Token: 0x0401400C RID: 81932
		internal static int __PropertyOffset_Float;

		// Token: 0x0401400D RID: 81933
		internal static int __PropertyOffset_Double;
	}
}
