using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200179D RID: 6045
	[UnrealObjectPath("/Script/KuroComputeShader.KuroClothTriangleData")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FKuroClothTriangleData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015CAF RID: 89263 RVA: 0x00200288 File Offset: 0x001FE488
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroClothTriangleData._ScriptStructPtr != 0) ? FKuroClothTriangleData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroClothTriangleData", ref FKuroClothTriangleData._ScriptStructPtr);
		}

		// Token: 0x17005654 RID: 22100
		// (get) Token: 0x06015CB0 RID: 89264 RVA: 0x002002AC File Offset: 0x001FE4AC
		// (set) Token: 0x06015CB1 RID: 89265 RVA: 0x002002BC File Offset: 0x001FE4BC
		public unsafe int ParticleA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothTriangleData.__PropertyOffset_ParticleA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothTriangleData.__PropertyOffset_ParticleA) = value;
			}
		}

		// Token: 0x17005655 RID: 22101
		// (get) Token: 0x06015CB2 RID: 89266 RVA: 0x002002CD File Offset: 0x001FE4CD
		// (set) Token: 0x06015CB3 RID: 89267 RVA: 0x002002DD File Offset: 0x001FE4DD
		public unsafe int ParticleB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothTriangleData.__PropertyOffset_ParticleB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothTriangleData.__PropertyOffset_ParticleB) = value;
			}
		}

		// Token: 0x17005656 RID: 22102
		// (get) Token: 0x06015CB4 RID: 89268 RVA: 0x002002EE File Offset: 0x001FE4EE
		// (set) Token: 0x06015CB5 RID: 89269 RVA: 0x002002FE File Offset: 0x001FE4FE
		public unsafe int ParticleC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothTriangleData.__PropertyOffset_ParticleC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothTriangleData.__PropertyOffset_ParticleC) = value;
			}
		}

		// Token: 0x06015CB6 RID: 89270 RVA: 0x0020030F File Offset: 0x001FE50F
		public FKuroClothTriangleData()
		{
		}

		// Token: 0x06015CB7 RID: 89271 RVA: 0x00200317 File Offset: 0x001FE517
		public FKuroClothTriangleData(int ParticleA, int ParticleB, int ParticleC)
		{
			this.ParticleA = ParticleA;
			this.ParticleB = ParticleB;
			this.ParticleC = ParticleC;
		}

		// Token: 0x06015CB8 RID: 89272 RVA: 0x00200334 File Offset: 0x001FE534
		protected override IntPtr GetUStructPtr()
		{
			return FKuroClothTriangleData.StaticStruct();
		}

		// Token: 0x06015CB9 RID: 89273 RVA: 0x00200340 File Offset: 0x001FE540
		[NullableContext(2)]
		public FKuroClothTriangleData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015CBA RID: 89274 RVA: 0x0020034A File Offset: 0x001FE54A
		public FKuroClothTriangleData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015CBB RID: 89275 RVA: 0x00200355 File Offset: 0x001FE555
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroClothTriangleData(Pointer, false, true);
		}

		// Token: 0x06015CBC RID: 89276 RVA: 0x0020035F File Offset: 0x001FE55F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroClothTriangleData(Pointer, MemoryOwner);
		}

		// Token: 0x0400BE3F RID: 48703
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroClothTriangleData";

		// Token: 0x0400BE40 RID: 48704
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BE41 RID: 48705
		internal static int __PropertyOffset_ParticleA;

		// Token: 0x0400BE42 RID: 48706
		internal static int __PropertyOffset_ParticleB;

		// Token: 0x0400BE43 RID: 48707
		internal static int __PropertyOffset_ParticleC;
	}
}
