using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000524 RID: 1316
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/ControlRig.RigHierarchyRef")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FRigHierarchyRef : IEqualityOperators<FRigHierarchyRef, FRigHierarchyRef, bool>, IEquatable<FRigHierarchyRef>, IUnrealScriptStruct
	{
		// Token: 0x06004500 RID: 17664 RVA: 0x00066BF8 File Offset: 0x00064DF8
		public unsafe static bool operator ==(FRigHierarchyRef left, FRigHierarchyRef right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00066C24 File Offset: 0x00064E24
		public static bool operator !=(FRigHierarchyRef left, FRigHierarchyRef right)
		{
			return !(left == right);
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00066C30 File Offset: 0x00064E30
		public bool Equals(FRigHierarchyRef other)
		{
			return this == other;
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00066C40 File Offset: 0x00064E40
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FRigHierarchyRef)
			{
				FRigHierarchyRef other = (FRigHierarchyRef)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00066C65 File Offset: 0x00064E65
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigHierarchyRef._ScriptStructPtr != 0) ? FRigHierarchyRef._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigHierarchyRef", ref FRigHierarchyRef._ScriptStructPtr);
		}

		// Token: 0x0400219E RID: 8606
		public const string __ObjectPath = "/Script/ControlRig.RigHierarchyRef";

		// Token: 0x0400219F RID: 8607
		private static IntPtr _ScriptStructPtr;
	}
}
