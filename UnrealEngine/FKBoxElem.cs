using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CC5 RID: 3269
	[UnrealObjectPath("/Script/Engine.KBoxElem")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FKBoxElem : FKShapeElem, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A533 RID: 42291 RVA: 0x000EAFD2 File Offset: 0x000E91D2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKBoxElem._ScriptStructPtr != 0) ? FKBoxElem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KBoxElem", ref FKBoxElem._ScriptStructPtr);
		}

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x0600A534 RID: 42292 RVA: 0x000EAFF6 File Offset: 0x000E91F6
		// (set) Token: 0x0600A535 RID: 42293 RVA: 0x000EB00A File Offset: 0x000E920A
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKBoxElem.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKBoxElem.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x0600A536 RID: 42294 RVA: 0x000EB01F File Offset: 0x000E921F
		// (set) Token: 0x0600A537 RID: 42295 RVA: 0x000EB033 File Offset: 0x000E9233
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKBoxElem.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKBoxElem.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x0600A538 RID: 42296 RVA: 0x000EB048 File Offset: 0x000E9248
		// (set) Token: 0x0600A539 RID: 42297 RVA: 0x000EB058 File Offset: 0x000E9258
		public unsafe float X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKBoxElem.__PropertyOffset_X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKBoxElem.__PropertyOffset_X) = value;
			}
		}

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x0600A53A RID: 42298 RVA: 0x000EB069 File Offset: 0x000E9269
		// (set) Token: 0x0600A53B RID: 42299 RVA: 0x000EB079 File Offset: 0x000E9279
		public unsafe float Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKBoxElem.__PropertyOffset_Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKBoxElem.__PropertyOffset_Y) = value;
			}
		}

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x0600A53C RID: 42300 RVA: 0x000EB08A File Offset: 0x000E928A
		// (set) Token: 0x0600A53D RID: 42301 RVA: 0x000EB09A File Offset: 0x000E929A
		public unsafe float Z
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKBoxElem.__PropertyOffset_Z);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKBoxElem.__PropertyOffset_Z) = value;
			}
		}

		// Token: 0x0600A53E RID: 42302 RVA: 0x000EB0AB File Offset: 0x000E92AB
		public FKBoxElem()
		{
		}

		// Token: 0x0600A53F RID: 42303 RVA: 0x000EB0B4 File Offset: 0x000E92B4
		public FKBoxElem(FMatrix TM_DEPRECATED, FQuat Orientation_DEPRECATED, FVector Center, FRotator Rotation, float X, float Y, float Z, float RestOffset, bool bIsGenerated, FName Name, bool bContributeToMass, TEnumAsByte<ECollisionEnabled> CollisionEnabled)
		{
			this.Center = Center;
			this.Rotation = Rotation;
			this.X = X;
			this.Y = Y;
			this.Z = Z;
			base.RestOffset = RestOffset;
			base.Name = Name;
			base.bContributeToMass = bContributeToMass;
			base.CollisionEnabled = CollisionEnabled;
		}

		// Token: 0x0600A540 RID: 42304 RVA: 0x000EB10E File Offset: 0x000E930E
		protected override IntPtr GetUStructPtr()
		{
			return FKBoxElem.StaticStruct();
		}

		// Token: 0x0600A541 RID: 42305 RVA: 0x000EB11A File Offset: 0x000E931A
		[NullableContext(2)]
		public FKBoxElem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A542 RID: 42306 RVA: 0x000EB124 File Offset: 0x000E9324
		public FKBoxElem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A543 RID: 42307 RVA: 0x000EB12F File Offset: 0x000E932F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKBoxElem(Pointer, false, true);
		}

		// Token: 0x0600A544 RID: 42308 RVA: 0x000EB139 File Offset: 0x000E9339
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKBoxElem(Pointer, MemoryOwner);
		}

		// Token: 0x04005AE1 RID: 23265
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KBoxElem";

		// Token: 0x04005AE2 RID: 23266
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005AE3 RID: 23267
		internal static int __PropertyOffset_Center;

		// Token: 0x04005AE4 RID: 23268
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04005AE5 RID: 23269
		internal static int __PropertyOffset_X;

		// Token: 0x04005AE6 RID: 23270
		internal static int __PropertyOffset_Y;

		// Token: 0x04005AE7 RID: 23271
		internal static int __PropertyOffset_Z;
	}
}
