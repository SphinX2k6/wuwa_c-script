using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000028 RID: 40
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.Guid")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FGuid : IEquatable<FGuid>, IEqualityOperators<FGuid, FGuid, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000180 RID: 384
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FGuid NewGuid();

		// Token: 0x06000181 RID: 385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid Internal_NewGuidFromName(in FCSharpStringView name);

		// Token: 0x06000182 RID: 386 RVA: 0x0000729C File Offset: 0x0000549C
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

		// Token: 0x06000183 RID: 387 RVA: 0x000072E8 File Offset: 0x000054E8
		public FGuid()
		{
			this.A = (this.B = (this.C = (this.D = 0U)));
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00007317 File Offset: 0x00005517
		public FGuid(uint a, uint b, uint c, uint d)
		{
			this.A = a;
			this.B = b;
			this.C = c;
			this.D = d;
		}

		// Token: 0x17000003 RID: 3
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

		// Token: 0x06000187 RID: 391 RVA: 0x000073C7 File Offset: 0x000055C7
		[NullableContext(1)]
		public override readonly string ToString()
		{
			return this.ToString(EGuidFormats.Digits);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000073D0 File Offset: 0x000055D0
		public readonly bool Equals(FGuid other)
		{
			return this == other;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000073E0 File Offset: 0x000055E0
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

		// Token: 0x0600018A RID: 394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FGuid a, in FGuid b);

		// Token: 0x0600018B RID: 395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_NotEq(in FGuid a, in FGuid b);

		// Token: 0x0600018C RID: 396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid Internal_Ctor_string(in FCSharpStringView str);

		// Token: 0x0600018D RID: 397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_LessThan(in FGuid a, in FGuid b);

		// Token: 0x0600018E RID: 398
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_LexToString(in FGuid a);

		// Token: 0x0600018F RID: 399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_LexFromString(out FGuid outGuid, in FCSharpStringView str);

		// Token: 0x06000190 RID: 400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Invalidate(ref FGuid a);

		// Token: 0x06000191 RID: 401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsValid(in FGuid a);

		// Token: 0x06000192 RID: 402
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_ToString(in FGuid a, EGuidFormats format);

		// Token: 0x06000193 RID: 403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint Internal_GetHashCode(in FGuid a);

		// Token: 0x06000194 RID: 404 RVA: 0x0000740C File Offset: 0x0000560C
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

		// Token: 0x06000195 RID: 405 RVA: 0x00007476 File Offset: 0x00005676
		public static bool operator ==(FGuid a, FGuid b)
		{
			return FGuid.Internal_Eq(a, b);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00007481 File Offset: 0x00005681
		public static bool operator !=(FGuid a, FGuid b)
		{
			return FGuid.Internal_NotEq(a, b);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000748C File Offset: 0x0000568C
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

		// Token: 0x06000198 RID: 408 RVA: 0x000074A8 File Offset: 0x000056A8
		public static bool operator >(in FGuid a, in FGuid b)
		{
			return b < a;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000074B4 File Offset: 0x000056B4
		[NullableContext(1)]
		public unsafe static string LexToString(in FGuid guid)
		{
			fixed (FGuid* ptr = &guid)
			{
				return FGuid.Internal_LexToString(guid);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000074CC File Offset: 0x000056CC
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

		// Token: 0x0600019B RID: 411 RVA: 0x0000751C File Offset: 0x0000571C
		public unsafe void Invalidate()
		{
			fixed (FGuid* ptr = &this)
			{
				FGuid.Internal_Invalidate(ref this);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00007538 File Offset: 0x00005738
		public unsafe readonly bool IsValid()
		{
			fixed (FGuid* ptr = &this)
			{
				return FGuid.Internal_IsValid(this);
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00007550 File Offset: 0x00005750
		[NullableContext(1)]
		public unsafe readonly string ToString(EGuidFormats format)
		{
			fixed (FGuid* ptr = &this)
			{
				return FGuid.Internal_ToString(this, format);
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00007568 File Offset: 0x00005768
		public unsafe override readonly int GetHashCode()
		{
			fixed (FGuid* ptr = &this)
			{
				return (int)FGuid.Internal_GetHashCode(this);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000757F File Offset: 0x0000577F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGuid._ScriptStructPtr != 0) ? FGuid._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Guid", ref FGuid._ScriptStructPtr);
		}

		// Token: 0x04000091 RID: 145
		[FieldOffset(0)]
		public uint A;

		// Token: 0x04000092 RID: 146
		[FieldOffset(4)]
		public uint B;

		// Token: 0x04000093 RID: 147
		[FieldOffset(8)]
		public uint C;

		// Token: 0x04000094 RID: 148
		[FieldOffset(12)]
		public uint D;

		// Token: 0x04000095 RID: 149
		public const string __ObjectPath = "/Script/CoreUObject.Guid";

		// Token: 0x04000096 RID: 150
		private static IntPtr _ScriptStructPtr;
	}
}
