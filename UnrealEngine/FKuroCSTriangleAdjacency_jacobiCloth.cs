using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017D2 RID: 6098
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSTriangleAdjacency_jacobiCloth")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroCSTriangleAdjacency_jacobiCloth : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016740 RID: 91968 RVA: 0x0020CDF0 File Offset: 0x0020AFF0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSTriangleAdjacency_jacobiCloth._ScriptStructPtr != 0) ? FKuroCSTriangleAdjacency_jacobiCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSTriangleAdjacency_jacobiCloth", ref FKuroCSTriangleAdjacency_jacobiCloth._ScriptStructPtr);
		}

		// Token: 0x17005A83 RID: 23171
		// (get) Token: 0x06016741 RID: 91969 RVA: 0x0020CE14 File Offset: 0x0020B014
		// (set) Token: 0x06016742 RID: 91970 RVA: 0x0020CE24 File Offset: 0x0020B024
		public unsafe int Particle0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSTriangleAdjacency_jacobiCloth.__PropertyOffset_Particle0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSTriangleAdjacency_jacobiCloth.__PropertyOffset_Particle0) = value;
			}
		}

		// Token: 0x17005A84 RID: 23172
		// (get) Token: 0x06016743 RID: 91971 RVA: 0x0020CE35 File Offset: 0x0020B035
		// (set) Token: 0x06016744 RID: 91972 RVA: 0x0020CE45 File Offset: 0x0020B045
		public unsafe int Particle1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSTriangleAdjacency_jacobiCloth.__PropertyOffset_Particle1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSTriangleAdjacency_jacobiCloth.__PropertyOffset_Particle1) = value;
			}
		}

		// Token: 0x17005A85 RID: 23173
		// (get) Token: 0x06016745 RID: 91973 RVA: 0x0020CE56 File Offset: 0x0020B056
		// (set) Token: 0x06016746 RID: 91974 RVA: 0x0020CE66 File Offset: 0x0020B066
		public unsafe int Particle2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSTriangleAdjacency_jacobiCloth.__PropertyOffset_Particle2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSTriangleAdjacency_jacobiCloth.__PropertyOffset_Particle2) = value;
			}
		}

		// Token: 0x17005A86 RID: 23174
		// (get) Token: 0x06016747 RID: 91975 RVA: 0x0020CE77 File Offset: 0x0020B077
		// (set) Token: 0x06016748 RID: 91976 RVA: 0x0020CE87 File Offset: 0x0020B087
		public unsafe int Pad0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSTriangleAdjacency_jacobiCloth.__PropertyOffset_Pad0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSTriangleAdjacency_jacobiCloth.__PropertyOffset_Pad0) = value;
			}
		}

		// Token: 0x06016749 RID: 91977 RVA: 0x0020CE98 File Offset: 0x0020B098
		public FKuroCSTriangleAdjacency_jacobiCloth()
		{
		}

		// Token: 0x0601674A RID: 91978 RVA: 0x0020CEA0 File Offset: 0x0020B0A0
		public FKuroCSTriangleAdjacency_jacobiCloth(int Particle0, int Particle1, int Particle2, int Pad0)
		{
			this.Particle0 = Particle0;
			this.Particle1 = Particle1;
			this.Particle2 = Particle2;
			this.Pad0 = Pad0;
		}

		// Token: 0x0601674B RID: 91979 RVA: 0x0020CEC5 File Offset: 0x0020B0C5
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSTriangleAdjacency_jacobiCloth.StaticStruct();
		}

		// Token: 0x0601674C RID: 91980 RVA: 0x0020CED1 File Offset: 0x0020B0D1
		[NullableContext(2)]
		public FKuroCSTriangleAdjacency_jacobiCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601674D RID: 91981 RVA: 0x0020CEDB File Offset: 0x0020B0DB
		public FKuroCSTriangleAdjacency_jacobiCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601674E RID: 91982 RVA: 0x0020CEE6 File Offset: 0x0020B0E6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSTriangleAdjacency_jacobiCloth(Pointer, false, true);
		}

		// Token: 0x0601674F RID: 91983 RVA: 0x0020CEF0 File Offset: 0x0020B0F0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSTriangleAdjacency_jacobiCloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400C331 RID: 49969
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSTriangleAdjacency_jacobiCloth";

		// Token: 0x0400C332 RID: 49970
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C333 RID: 49971
		internal static int __PropertyOffset_Particle0;

		// Token: 0x0400C334 RID: 49972
		internal static int __PropertyOffset_Particle1;

		// Token: 0x0400C335 RID: 49973
		internal static int __PropertyOffset_Particle2;

		// Token: 0x0400C336 RID: 49974
		internal static int __PropertyOffset_Pad0;
	}
}
