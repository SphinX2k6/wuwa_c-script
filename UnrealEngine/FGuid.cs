using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200000D RID: 13
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.Guid")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FGuid : IEquatable<FGuid>, IEqualityOperators<FGuid, FGuid, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000105 RID: 261
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FGuid NewGuid();

		// Token: 0x06000106 RID: 262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid Internal_NewGuidFromName(in FCSharpStringView name);

		// Token: 0x06000107 RID: 263 RVA: 0x00003B08 File Offset: 0x00001D08
		[NullableContext(2)]
		public unsafe static FGuid NewGuidFromName(string name)
		{
			FCSharpStringView fcsharpStringView;
			if (name == null || name.Length == 0)
			{
				fcsharpStringView = new FCSharpStringView(null, 0);
				return FGuid.Internal_NewGuidFromName(fcsharpStringView);
			}
			char* ptr;
			if (name == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = name.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			fcsharpStringView = new FCSharpStringView(ptr, name.Length);
			return FGuid.Internal_NewGuidFromName(fcsharpStringView);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003B54 File Offset: 0x00001D54
		public FGuid()
		{
			this.A = (this.B = (this.C = (this.D = 0U)));
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00003B83 File Offset: 0x00001D83
		public FGuid(uint a, uint b, uint c, uint d)
		{
			this.A = a;
			this.B = b;
			this.C = c;
			this.D = d;
		}

		// Token: 0x17000002 RID: 2
		public uint this[int index]
		{
			readonly get
			{
				uint result;
				switch (index)
				{
				case 0:
					result = this.A;
					break;
				case 1:
					result = this.B;
					break;
				case 2:
					result = this.C;
					break;
				case 3:
					result = this.D;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
				return result;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.A = value;
					return;
				case 1:
					this.B = value;
					return;
				case 2:
					this.C = value;
					return;
				case 3:
					this.D = value;
					return;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00003C33 File Offset: 0x00001E33
		[NullableContext(1)]
		public override readonly string ToString()
		{
			return this.ToString(EGuidFormats.Digits);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00003C3C File Offset: 0x00001E3C
		public readonly bool Equals(FGuid other)
		{
			return this == other;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00003C4C File Offset: 0x00001E4C
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FGuid)
			{
				FGuid b = (FGuid)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x0600010F RID: 271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FGuid a, in FGuid b);

		// Token: 0x06000110 RID: 272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_NotEq(in FGuid a, in FGuid b);

		// Token: 0x06000111 RID: 273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid Internal_Ctor_string(in FCSharpStringView str);

		// Token: 0x06000112 RID: 274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_LessThan(in FGuid a, in FGuid b);

		// Token: 0x06000113 RID: 275
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_LexToString(in FGuid a);

		// Token: 0x06000114 RID: 276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_LexFromString(out FGuid outGuid, in FCSharpStringView str);

		// Token: 0x06000115 RID: 277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Invalidate(ref FGuid a);

		// Token: 0x06000116 RID: 278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsValid(in FGuid a);

		// Token: 0x06000117 RID: 279
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_ToString(in FGuid a, EGuidFormats format);

		// Token: 0x06000118 RID: 280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint Internal_GetHashCode(in FGuid a);

		// Token: 0x06000119 RID: 281 RVA: 0x00003C78 File Offset: 0x00001E78
		[NullableContext(2)]
		public unsafe FGuid(string str)
		{
			this.A = 0U;
			this.B = 0U;
			this.C = 0U;
			this.D = 0U;
			if (str != null && str.Length > 0)
			{
				char* ptr;
				if (str == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = str.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* ptr3 = ptr;
				fixed (FGuid* ptr4 = &this)
				{
					FCSharpStringView fcsharpStringView = new FCSharpStringView(ptr3, str.Length);
					this = FGuid.Internal_Ctor_string(fcsharpStringView);
				}
				char* ptr2 = null;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00003CE2 File Offset: 0x00001EE2
		public static bool operator ==(FGuid a, FGuid b)
		{
			return FGuid.Internal_Eq(a, b);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00003CED File Offset: 0x00001EED
		public static bool operator !=(FGuid a, FGuid b)
		{
			return FGuid.Internal_NotEq(a, b);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public unsafe static bool operator <(in FGuid a, in FGuid b)
		{
			fixed (FGuid* ptr = &a)
			{
				fixed (FGuid* ptr2 = &a)
				{
					return FGuid.Internal_LessThan(a, b);
				}
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00003D14 File Offset: 0x00001F14
		public static bool operator >(in FGuid a, in FGuid b)
		{
			return b < a;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00003D20 File Offset: 0x00001F20
		[NullableContext(1)]
		public unsafe static string LexToString(in FGuid guid)
		{
			fixed (FGuid* ptr = &guid)
			{
				return FGuid.Internal_LexToString(guid);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00003D38 File Offset: 0x00001F38
		[NullableContext(2)]
		public unsafe static void LexFromString(out FGuid guid, string str)
		{
			if (str == null || str.Length == 0)
			{
				guid = default(FGuid);
				return;
			}
			fixed (FGuid* ptr = &guid)
			{
				char* ptr2;
				if (str == null)
				{
					ptr2 = null;
				}
				else
				{
					fixed (char* ptr3 = str.GetPinnableReference())
					{
						ptr2 = ptr3;
					}
				}
				char* ptr4 = ptr2;
				FCSharpStringView fcsharpStringView = new FCSharpStringView(ptr4, str.Length);
				FGuid.Internal_LexFromString(out guid, fcsharpStringView);
				char* ptr3 = null;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00003D88 File Offset: 0x00001F88
		public unsafe void Invalidate()
		{
			fixed (FGuid* ptr = &this)
			{
				FGuid.Internal_Invalidate(ref this);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00003DA4 File Offset: 0x00001FA4
		public unsafe readonly bool IsValid()
		{
			fixed (FGuid* ptr = &this)
			{
				return FGuid.Internal_IsValid(this);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00003DBC File Offset: 0x00001FBC
		[NullableContext(1)]
		public unsafe readonly string ToString(EGuidFormats format)
		{
			fixed (FGuid* ptr = &this)
			{
				return FGuid.Internal_ToString(this, format);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00003DD4 File Offset: 0x00001FD4
		public unsafe override readonly int GetHashCode()
		{
			fixed (FGuid* ptr = &this)
			{
				return (int)FGuid.Internal_GetHashCode(this);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00003DEB File Offset: 0x00001FEB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGuid._ScriptStructPtr != 0) ? FGuid._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Guid", ref FGuid._ScriptStructPtr);
		}

		// Token: 0x0400004A RID: 74
		[FieldOffset(0)]
		public uint A;

		// Token: 0x0400004B RID: 75
		[FieldOffset(4)]
		public uint B;

		// Token: 0x0400004C RID: 76
		[FieldOffset(8)]
		public uint C;

		// Token: 0x0400004D RID: 77
		[FieldOffset(12)]
		public uint D;

		// Token: 0x0400004E RID: 78
		public const string __ObjectPath = "/Script/CoreUObject.Guid";

		// Token: 0x0400004F RID: 79
		private static IntPtr _ScriptStructPtr;
	}
}
