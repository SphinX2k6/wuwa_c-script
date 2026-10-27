using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200035A RID: 858
	[UnrealObjectPath("/Script/ApexDestruction.FractureMaterial")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FFractureMaterial : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002FB0 RID: 12208 RVA: 0x000491CA File Offset: 0x000473CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFractureMaterial._ScriptStructPtr != 0) ? FFractureMaterial._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ApexDestruction.FractureMaterial", ref FFractureMaterial._ScriptStructPtr);
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x000491EE File Offset: 0x000473EE
		// (set) Token: 0x06002FB2 RID: 12210 RVA: 0x00049202 File Offset: 0x00047402
		public unsafe FVector2D UVScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFractureMaterial.__PropertyOffset_UVScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFractureMaterial.__PropertyOffset_UVScale) = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x00049217 File Offset: 0x00047417
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x0004922B File Offset: 0x0004742B
		public unsafe FVector2D UVOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFractureMaterial.__PropertyOffset_UVOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFractureMaterial.__PropertyOffset_UVOffset) = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x00049240 File Offset: 0x00047440
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x00049254 File Offset: 0x00047454
		public unsafe FVector Tangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFractureMaterial.__PropertyOffset_Tangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFractureMaterial.__PropertyOffset_Tangent) = value;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x00049269 File Offset: 0x00047469
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x00049279 File Offset: 0x00047479
		public unsafe float UAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFractureMaterial.__PropertyOffset_UAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFractureMaterial.__PropertyOffset_UAngle) = value;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x0004928A File Offset: 0x0004748A
		// (set) Token: 0x06002FBA RID: 12218 RVA: 0x0004929A File Offset: 0x0004749A
		public unsafe int InteriorElementIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFractureMaterial.__PropertyOffset_InteriorElementIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFractureMaterial.__PropertyOffset_InteriorElementIndex) = value;
			}
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x000492AB File Offset: 0x000474AB
		public FFractureMaterial()
		{
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x000492B3 File Offset: 0x000474B3
		public FFractureMaterial(FVector2D UVScale, FVector2D UVOffset, FVector Tangent, float UAngle, int InteriorElementIndex)
		{
			this.UVScale = UVScale;
			this.UVOffset = UVOffset;
			this.Tangent = Tangent;
			this.UAngle = UAngle;
			this.InteriorElementIndex = InteriorElementIndex;
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x000492E0 File Offset: 0x000474E0
		protected override IntPtr GetUStructPtr()
		{
			return FFractureMaterial.StaticStruct();
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x000492EC File Offset: 0x000474EC
		[NullableContext(2)]
		public FFractureMaterial(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x000492F6 File Offset: 0x000474F6
		public FFractureMaterial(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x00049301 File Offset: 0x00047501
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFractureMaterial(Pointer, false, true);
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x0004930B File Offset: 0x0004750B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFractureMaterial(Pointer, MemoryOwner);
		}

		// Token: 0x040014AC RID: 5292
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ApexDestruction.FractureMaterial";

		// Token: 0x040014AD RID: 5293
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040014AE RID: 5294
		internal static int __PropertyOffset_UVScale;

		// Token: 0x040014AF RID: 5295
		internal static int __PropertyOffset_UVOffset;

		// Token: 0x040014B0 RID: 5296
		internal static int __PropertyOffset_Tangent;

		// Token: 0x040014B1 RID: 5297
		internal static int __PropertyOffset_UAngle;

		// Token: 0x040014B2 RID: 5298
		internal static int __PropertyOffset_InteriorElementIndex;
	}
}
