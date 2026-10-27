using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012DF RID: 4831
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/GameMatrix.CameraInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FCameraInfo : IEqualityOperators<FCameraInfo, FCameraInfo, bool>, IEquatable<FCameraInfo>, IUnrealScriptStruct
	{
		// Token: 0x06011B2D RID: 72493 RVA: 0x0019FC6F File Offset: 0x0019DE6F
		public FCameraInfo(bool HasCamera)
		{
			this.HasCamera = HasCamera;
		}

		// Token: 0x06011B2E RID: 72494 RVA: 0x0019FC78 File Offset: 0x0019DE78
		public static bool operator ==(FCameraInfo left, FCameraInfo right)
		{
			return left.HasCamera == right.HasCamera;
		}

		// Token: 0x06011B2F RID: 72495 RVA: 0x0019FC88 File Offset: 0x0019DE88
		public static bool operator !=(FCameraInfo left, FCameraInfo right)
		{
			return !(left == right);
		}

		// Token: 0x06011B30 RID: 72496 RVA: 0x0019FC94 File Offset: 0x0019DE94
		public bool Equals(FCameraInfo other)
		{
			return this == other;
		}

		// Token: 0x06011B31 RID: 72497 RVA: 0x0019FCA4 File Offset: 0x0019DEA4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FCameraInfo)
			{
				FCameraInfo other = (FCameraInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06011B32 RID: 72498 RVA: 0x0019FCC9 File Offset: 0x0019DEC9
		public override int GetHashCode()
		{
			return HashCode.Combine<bool>(this.HasCamera);
		}

		// Token: 0x06011B33 RID: 72499 RVA: 0x0019FCD6 File Offset: 0x0019DED6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraInfo._ScriptStructPtr != 0) ? FCameraInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameMatrix.CameraInfo", ref FCameraInfo._ScriptStructPtr);
		}

		// Token: 0x04009806 RID: 38918
		[FieldOffset(0)]
		public bool HasCamera;

		// Token: 0x04009807 RID: 38919
		public const string __ObjectPath = "/Script/GameMatrix.CameraInfo";

		// Token: 0x04009808 RID: 38920
		private static IntPtr _ScriptStructPtr;
	}
}
