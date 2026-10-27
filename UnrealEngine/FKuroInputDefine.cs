using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018DA RID: 6362
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroInputDefine")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FKuroInputDefine : IEqualityOperators<FKuroInputDefine, FKuroInputDefine, bool>, IEquatable<FKuroInputDefine>, IUnrealScriptStruct
	{
		// Token: 0x06017922 RID: 96546 RVA: 0x0022805C File Offset: 0x0022625C
		public unsafe static bool operator ==(FKuroInputDefine left, FKuroInputDefine right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06017923 RID: 96547 RVA: 0x00228088 File Offset: 0x00226288
		public static bool operator !=(FKuroInputDefine left, FKuroInputDefine right)
		{
			return !(left == right);
		}

		// Token: 0x06017924 RID: 96548 RVA: 0x00228094 File Offset: 0x00226294
		public bool Equals(FKuroInputDefine other)
		{
			return this == other;
		}

		// Token: 0x06017925 RID: 96549 RVA: 0x002280A4 File Offset: 0x002262A4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKuroInputDefine)
			{
				FKuroInputDefine other = (FKuroInputDefine)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06017926 RID: 96550 RVA: 0x002280C9 File Offset: 0x002262C9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroInputDefine._ScriptStructPtr != 0) ? FKuroInputDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroInputDefine", ref FKuroInputDefine._ScriptStructPtr);
		}

		// Token: 0x0400CCB6 RID: 52406
		public const string __ObjectPath = "/Script/KuroGameplay.KuroInputDefine";

		// Token: 0x0400CCB7 RID: 52407
		private static IntPtr _ScriptStructPtr;
	}
}
