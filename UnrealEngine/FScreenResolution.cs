using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001741 RID: 5953
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/KuroCloudGame.ScreenResolution")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FScreenResolution : IEqualityOperators<FScreenResolution, FScreenResolution, bool>, IEquatable<FScreenResolution>, IUnrealScriptStruct
	{
		// Token: 0x060156BD RID: 87741 RVA: 0x001F7B0C File Offset: 0x001F5D0C
		public FScreenResolution(int Height, int Width)
		{
			this.Height = Height;
			this.Width = Width;
		}

		// Token: 0x060156BE RID: 87742 RVA: 0x001F7B1C File Offset: 0x001F5D1C
		public static bool operator ==(FScreenResolution left, FScreenResolution right)
		{
			return left.Height == right.Height && left.Width == right.Width;
		}

		// Token: 0x060156BF RID: 87743 RVA: 0x001F7B3C File Offset: 0x001F5D3C
		public static bool operator !=(FScreenResolution left, FScreenResolution right)
		{
			return !(left == right);
		}

		// Token: 0x060156C0 RID: 87744 RVA: 0x001F7B48 File Offset: 0x001F5D48
		public bool Equals(FScreenResolution other)
		{
			return this == other;
		}

		// Token: 0x060156C1 RID: 87745 RVA: 0x001F7B58 File Offset: 0x001F5D58
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FScreenResolution)
			{
				FScreenResolution other = (FScreenResolution)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060156C2 RID: 87746 RVA: 0x001F7B7D File Offset: 0x001F5D7D
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.Height, this.Width);
		}

		// Token: 0x060156C3 RID: 87747 RVA: 0x001F7B90 File Offset: 0x001F5D90
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FScreenResolution._ScriptStructPtr != 0) ? FScreenResolution._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCloudGame.ScreenResolution", ref FScreenResolution._ScriptStructPtr);
		}

		// Token: 0x0400BADD RID: 47837
		[FieldOffset(0)]
		public int Height;

		// Token: 0x0400BADE RID: 47838
		[FieldOffset(4)]
		public int Width;

		// Token: 0x0400BADF RID: 47839
		public const string __ObjectPath = "/Script/KuroCloudGame.ScreenResolution";

		// Token: 0x0400BAE0 RID: 47840
		private static IntPtr _ScriptStructPtr;
	}
}
