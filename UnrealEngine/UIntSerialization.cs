using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CBA RID: 3258
	[UnrealObjectPath("/Script/Engine.IntSerialization")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UIntSerialization : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A4B4 RID: 42164 RVA: 0x000EA659 File Offset: 0x000E8859
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UIntSerialization._ClassPtr;
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x000EA668 File Offset: 0x000E8868
		public UIntSerialization() : this(BuiltinUtils.AllocNativeUObject(UIntSerialization.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A4B6 RID: 42166 RVA: 0x000EA690 File Offset: 0x000E8890
		[NullableContext(1)]
		public UIntSerialization(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UIntSerialization.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x0600A4B7 RID: 42167 RVA: 0x000EA6C3 File Offset: 0x000E88C3
		// (set) Token: 0x0600A4B8 RID: 42168 RVA: 0x000EA6D3 File Offset: 0x000E88D3
		public unsafe ushort UnsignedInt16Variable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_UnsignedInt16Variable);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_UnsignedInt16Variable) = (short)value;
			}
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x0600A4B9 RID: 42169 RVA: 0x000EA6E4 File Offset: 0x000E88E4
		// (set) Token: 0x0600A4BA RID: 42170 RVA: 0x000EA6F4 File Offset: 0x000E88F4
		public unsafe uint UnsignedInt32Variable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_UnsignedInt32Variable);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_UnsignedInt32Variable) = (int)value;
			}
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x0600A4BB RID: 42171 RVA: 0x000EA705 File Offset: 0x000E8905
		// (set) Token: 0x0600A4BC RID: 42172 RVA: 0x000EA715 File Offset: 0x000E8915
		public unsafe ulong UnsignedInt64Variable
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_UnsignedInt64Variable));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_UnsignedInt64Variable) = (long)value;
			}
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x0600A4BD RID: 42173 RVA: 0x000EA726 File Offset: 0x000E8926
		// (set) Token: 0x0600A4BE RID: 42174 RVA: 0x000EA736 File Offset: 0x000E8936
		public unsafe sbyte SignedInt8Variable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_SignedInt8Variable);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_SignedInt8Variable) = (byte)value;
			}
		}

		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x0600A4BF RID: 42175 RVA: 0x000EA747 File Offset: 0x000E8947
		// (set) Token: 0x0600A4C0 RID: 42176 RVA: 0x000EA757 File Offset: 0x000E8957
		public unsafe short SignedInt16Variable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_SignedInt16Variable);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_SignedInt16Variable) = value;
			}
		}

		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x0600A4C1 RID: 42177 RVA: 0x000EA768 File Offset: 0x000E8968
		// (set) Token: 0x0600A4C2 RID: 42178 RVA: 0x000EA778 File Offset: 0x000E8978
		public unsafe long SignedInt64Variable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_SignedInt64Variable);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_SignedInt64Variable) = value;
			}
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x0600A4C3 RID: 42179 RVA: 0x000EA789 File Offset: 0x000E8989
		// (set) Token: 0x0600A4C4 RID: 42180 RVA: 0x000EA799 File Offset: 0x000E8999
		public unsafe byte UnsignedInt8Variable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_UnsignedInt8Variable);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_UnsignedInt8Variable) = value;
			}
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x0600A4C5 RID: 42181 RVA: 0x000EA7AA File Offset: 0x000E89AA
		// (set) Token: 0x0600A4C6 RID: 42182 RVA: 0x000EA7BA File Offset: 0x000E89BA
		public unsafe int SignedInt32Variable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_SignedInt32Variable);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UIntSerialization.__PropertyOffset_SignedInt32Variable) = value;
			}
		}

		// Token: 0x0600A4C7 RID: 42183 RVA: 0x000EA7CB File Offset: 0x000E89CB
		static UIntSerialization()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.IntSerialization");
		}

		// Token: 0x0600A4C8 RID: 42184 RVA: 0x000EA7D9 File Offset: 0x000E89D9
		protected UIntSerialization(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005AAA RID: 23210
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.IntSerialization";

		// Token: 0x04005AAB RID: 23211
		private static IntPtr _ClassPtr;

		// Token: 0x04005AAC RID: 23212
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005AAD RID: 23213
		internal static int __PropertyOffset_UnsignedInt16Variable;

		// Token: 0x04005AAE RID: 23214
		internal static int __PropertyOffset_UnsignedInt32Variable;

		// Token: 0x04005AAF RID: 23215
		internal static int __PropertyOffset_UnsignedInt64Variable;

		// Token: 0x04005AB0 RID: 23216
		internal static int __PropertyOffset_SignedInt8Variable;

		// Token: 0x04005AB1 RID: 23217
		internal static int __PropertyOffset_SignedInt16Variable;

		// Token: 0x04005AB2 RID: 23218
		internal static int __PropertyOffset_SignedInt64Variable;

		// Token: 0x04005AB3 RID: 23219
		internal static int __PropertyOffset_UnsignedInt8Variable;

		// Token: 0x04005AB4 RID: 23220
		internal static int __PropertyOffset_SignedInt32Variable;
	}
}
