using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200173D RID: 5949
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/KuroCloudGame.DeviceResolution")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FDeviceResolution : IEqualityOperators<FDeviceResolution, FDeviceResolution, bool>, IEquatable<FDeviceResolution>, IUnrealScriptStruct
	{
		// Token: 0x0601567E RID: 87678 RVA: 0x001F747D File Offset: 0x001F567D
		public FDeviceResolution(int Height, int Width)
		{
			this.Height = Height;
			this.Width = Width;
		}

		// Token: 0x0601567F RID: 87679 RVA: 0x001F748D File Offset: 0x001F568D
		public static bool operator ==(FDeviceResolution left, FDeviceResolution right)
		{
			return left.Height == right.Height && left.Width == right.Width;
		}

		// Token: 0x06015680 RID: 87680 RVA: 0x001F74AD File Offset: 0x001F56AD
		public static bool operator !=(FDeviceResolution left, FDeviceResolution right)
		{
			return !(left == right);
		}

		// Token: 0x06015681 RID: 87681 RVA: 0x001F74B9 File Offset: 0x001F56B9
		public bool Equals(FDeviceResolution other)
		{
			return this == other;
		}

		// Token: 0x06015682 RID: 87682 RVA: 0x001F74C8 File Offset: 0x001F56C8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FDeviceResolution)
			{
				FDeviceResolution other = (FDeviceResolution)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06015683 RID: 87683 RVA: 0x001F74ED File Offset: 0x001F56ED
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.Height, this.Width);
		}

		// Token: 0x06015684 RID: 87684 RVA: 0x001F7500 File Offset: 0x001F5700
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDeviceResolution._ScriptStructPtr != 0) ? FDeviceResolution._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCloudGame.DeviceResolution", ref FDeviceResolution._ScriptStructPtr);
		}

		// Token: 0x0400BABB RID: 47803
		[FieldOffset(0)]
		public int Height;

		// Token: 0x0400BABC RID: 47804
		[FieldOffset(4)]
		public int Width;

		// Token: 0x0400BABD RID: 47805
		public const string __ObjectPath = "/Script/KuroCloudGame.DeviceResolution";

		// Token: 0x0400BABE RID: 47806
		private static IntPtr _ScriptStructPtr;
	}
}
