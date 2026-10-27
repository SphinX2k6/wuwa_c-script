using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017FD RID: 6141
	[UnrealObjectPath("/Script/KuroData.TraceLineElement")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UTraceLineElement : UTraceBaseElement, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016BD3 RID: 93139 RVA: 0x00212E93 File Offset: 0x00211093
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTraceLineElement._ClassPtr;
		}

		// Token: 0x06016BD4 RID: 93140 RVA: 0x00212EA0 File Offset: 0x002110A0
		public UTraceLineElement() : this(BuiltinUtils.AllocNativeUObject(UTraceLineElement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016BD5 RID: 93141 RVA: 0x00212EC8 File Offset: 0x002110C8
		[NullableContext(1)]
		public UTraceLineElement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTraceLineElement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016BD6 RID: 93142 RVA: 0x00212EFB File Offset: 0x002110FB
		static UTraceLineElement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.TraceLineElement");
		}

		// Token: 0x06016BD7 RID: 93143 RVA: 0x00212F09 File Offset: 0x00211109
		protected UTraceLineElement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C579 RID: 50553
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroData.TraceLineElement";

		// Token: 0x0400C57A RID: 50554
		private static IntPtr _ClassPtr;

		// Token: 0x0400C57B RID: 50555
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
