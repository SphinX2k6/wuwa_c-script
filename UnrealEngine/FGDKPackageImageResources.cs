using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001404 RID: 5124
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/GDKPlatformEditor.GDKPackageImageResources")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FGDKPackageImageResources : IEqualityOperators<FGDKPackageImageResources, FGDKPackageImageResources, bool>, IEquatable<FGDKPackageImageResources>, IUnrealScriptStruct
	{
		// Token: 0x06012B06 RID: 76550 RVA: 0x001B8320 File Offset: 0x001B6520
		public unsafe static bool operator ==(FGDKPackageImageResources left, FGDKPackageImageResources right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06012B07 RID: 76551 RVA: 0x001B834C File Offset: 0x001B654C
		public static bool operator !=(FGDKPackageImageResources left, FGDKPackageImageResources right)
		{
			return !(left == right);
		}

		// Token: 0x06012B08 RID: 76552 RVA: 0x001B8358 File Offset: 0x001B6558
		public bool Equals(FGDKPackageImageResources other)
		{
			return this == other;
		}

		// Token: 0x06012B09 RID: 76553 RVA: 0x001B8368 File Offset: 0x001B6568
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FGDKPackageImageResources)
			{
				FGDKPackageImageResources other = (FGDKPackageImageResources)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06012B0A RID: 76554 RVA: 0x001B838D File Offset: 0x001B658D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGDKPackageImageResources._ScriptStructPtr != 0) ? FGDKPackageImageResources._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GDKPlatformEditor.GDKPackageImageResources", ref FGDKPackageImageResources._ScriptStructPtr);
		}

		// Token: 0x04009FDB RID: 40923
		public const string __ObjectPath = "/Script/GDKPlatformEditor.GDKPackageImageResources";

		// Token: 0x04009FDC RID: 40924
		private static IntPtr _ScriptStructPtr;
	}
}
