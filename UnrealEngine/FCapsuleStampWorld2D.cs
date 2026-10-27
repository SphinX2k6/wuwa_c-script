using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A55 RID: 6741
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CapsuleStampWorld2D")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FCapsuleStampWorld2D : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018EB1 RID: 102065 RVA: 0x0024D520 File Offset: 0x0024B720
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCapsuleStampWorld2D._ScriptStructPtr != 0) ? FCapsuleStampWorld2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.CapsuleStampWorld2D", ref FCapsuleStampWorld2D._ScriptStructPtr);
		}

		// Token: 0x170062A6 RID: 25254
		// (get) Token: 0x06018EB2 RID: 102066 RVA: 0x0024D544 File Offset: 0x0024B744
		// (set) Token: 0x06018EB3 RID: 102067 RVA: 0x0024D558 File Offset: 0x0024B758
		public unsafe FVectorDouble WorldA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_WorldA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_WorldA) = value;
			}
		}

		// Token: 0x170062A7 RID: 25255
		// (get) Token: 0x06018EB4 RID: 102068 RVA: 0x0024D56D File Offset: 0x0024B76D
		// (set) Token: 0x06018EB5 RID: 102069 RVA: 0x0024D581 File Offset: 0x0024B781
		public unsafe FVectorDouble WorldB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_WorldB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_WorldB) = value;
			}
		}

		// Token: 0x170062A8 RID: 25256
		// (get) Token: 0x06018EB6 RID: 102070 RVA: 0x0024D596 File Offset: 0x0024B796
		// (set) Token: 0x06018EB7 RID: 102071 RVA: 0x0024D5A6 File Offset: 0x0024B7A6
		public unsafe float RadiusWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_RadiusWorld);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_RadiusWorld) = value;
			}
		}

		// Token: 0x170062A9 RID: 25257
		// (get) Token: 0x06018EB8 RID: 102072 RVA: 0x0024D5B7 File Offset: 0x0024B7B7
		// (set) Token: 0x06018EB9 RID: 102073 RVA: 0x0024D5C7 File Offset: 0x0024B7C7
		public unsafe float SoftEdgeWidthWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_SoftEdgeWidthWorld);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_SoftEdgeWidthWorld) = value;
			}
		}

		// Token: 0x170062AA RID: 25258
		// (get) Token: 0x06018EBA RID: 102074 RVA: 0x0024D5D8 File Offset: 0x0024B7D8
		// (set) Token: 0x06018EBB RID: 102075 RVA: 0x0024D5E8 File Offset: 0x0024B7E8
		public unsafe bool bUseEndValues
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_bUseEndValues) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_bUseEndValues) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062AB RID: 25259
		// (get) Token: 0x06018EBC RID: 102076 RVA: 0x0024D5F9 File Offset: 0x0024B7F9
		// (set) Token: 0x06018EBD RID: 102077 RVA: 0x0024D609 File Offset: 0x0024B809
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170062AC RID: 25260
		// (get) Token: 0x06018EBE RID: 102078 RVA: 0x0024D61A File Offset: 0x0024B81A
		// (set) Token: 0x06018EBF RID: 102079 RVA: 0x0024D62A File Offset: 0x0024B82A
		public unsafe float ValueA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_ValueA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_ValueA) = value;
			}
		}

		// Token: 0x170062AD RID: 25261
		// (get) Token: 0x06018EC0 RID: 102080 RVA: 0x0024D63B File Offset: 0x0024B83B
		// (set) Token: 0x06018EC1 RID: 102081 RVA: 0x0024D64B File Offset: 0x0024B84B
		public unsafe float ValueB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_ValueB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleStampWorld2D.__PropertyOffset_ValueB) = value;
			}
		}

		// Token: 0x06018EC2 RID: 102082 RVA: 0x0024D65C File Offset: 0x0024B85C
		public FCapsuleStampWorld2D()
		{
		}

		// Token: 0x06018EC3 RID: 102083 RVA: 0x0024D664 File Offset: 0x0024B864
		public FCapsuleStampWorld2D(FVectorDouble WorldA, FVectorDouble WorldB, float RadiusWorld, float SoftEdgeWidthWorld, bool bUseEndValues, float Value, float ValueA, float ValueB)
		{
			this.WorldA = WorldA;
			this.WorldB = WorldB;
			this.RadiusWorld = RadiusWorld;
			this.SoftEdgeWidthWorld = SoftEdgeWidthWorld;
			this.bUseEndValues = bUseEndValues;
			this.Value = Value;
			this.ValueA = ValueA;
			this.ValueB = ValueB;
		}

		// Token: 0x06018EC4 RID: 102084 RVA: 0x0024D6B4 File Offset: 0x0024B8B4
		protected override IntPtr GetUStructPtr()
		{
			return FCapsuleStampWorld2D.StaticStruct();
		}

		// Token: 0x06018EC5 RID: 102085 RVA: 0x0024D6C0 File Offset: 0x0024B8C0
		[NullableContext(2)]
		public FCapsuleStampWorld2D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018EC6 RID: 102086 RVA: 0x0024D6CA File Offset: 0x0024B8CA
		public FCapsuleStampWorld2D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018EC7 RID: 102087 RVA: 0x0024D6D5 File Offset: 0x0024B8D5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCapsuleStampWorld2D(Pointer, false, true);
		}

		// Token: 0x06018EC8 RID: 102088 RVA: 0x0024D6DF File Offset: 0x0024B8DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCapsuleStampWorld2D(Pointer, MemoryOwner);
		}

		// Token: 0x0400D7B3 RID: 55219
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CapsuleStampWorld2D";

		// Token: 0x0400D7B4 RID: 55220
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D7B5 RID: 55221
		internal static int __PropertyOffset_WorldA;

		// Token: 0x0400D7B6 RID: 55222
		internal static int __PropertyOffset_WorldB;

		// Token: 0x0400D7B7 RID: 55223
		internal static int __PropertyOffset_RadiusWorld;

		// Token: 0x0400D7B8 RID: 55224
		internal static int __PropertyOffset_SoftEdgeWidthWorld;

		// Token: 0x0400D7B9 RID: 55225
		internal static int __PropertyOffset_bUseEndValues;

		// Token: 0x0400D7BA RID: 55226
		internal static int __PropertyOffset_Value;

		// Token: 0x0400D7BB RID: 55227
		internal static int __PropertyOffset_ValueA;

		// Token: 0x0400D7BC RID: 55228
		internal static int __PropertyOffset_ValueB;
	}
}
