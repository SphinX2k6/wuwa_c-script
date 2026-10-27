using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008A3 RID: 2211
	[UnrealObjectPath("/Script/Engine.BasedMovementInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FBasedMovementInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060078F5 RID: 30965 RVA: 0x000AD2EC File Offset: 0x000AB4EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBasedMovementInfo._ScriptStructPtr != 0) ? FBasedMovementInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BasedMovementInfo", ref FBasedMovementInfo._ScriptStructPtr);
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x060078F6 RID: 30966 RVA: 0x000AD310 File Offset: 0x000AB510
		// (set) Token: 0x060078F7 RID: 30967 RVA: 0x000AD324 File Offset: 0x000AB524
		[Nullable(2)]
		public unsafe UPrimitiveComponent MovementBase
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FBasedMovementInfo.__PropertyOffset_MovementBase);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBasedMovementInfo.__PropertyOffset_MovementBase, value);
			}
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x060078F8 RID: 30968 RVA: 0x000AD339 File Offset: 0x000AB539
		// (set) Token: 0x060078F9 RID: 30969 RVA: 0x000AD34D File Offset: 0x000AB54D
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x060078FA RID: 30970 RVA: 0x000AD362 File Offset: 0x000AB562
		// (set) Token: 0x060078FB RID: 30971 RVA: 0x000AD376 File Offset: 0x000AB576
		public unsafe FVector_NetQuantize100 Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x060078FC RID: 30972 RVA: 0x000AD38B File Offset: 0x000AB58B
		// (set) Token: 0x060078FD RID: 30973 RVA: 0x000AD39F File Offset: 0x000AB59F
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x060078FE RID: 30974 RVA: 0x000AD3B4 File Offset: 0x000AB5B4
		// (set) Token: 0x060078FF RID: 30975 RVA: 0x000AD3C4 File Offset: 0x000AB5C4
		public unsafe bool bServerHasBaseComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_bServerHasBaseComponent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_bServerHasBaseComponent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06007900 RID: 30976 RVA: 0x000AD3D5 File Offset: 0x000AB5D5
		// (set) Token: 0x06007901 RID: 30977 RVA: 0x000AD3E5 File Offset: 0x000AB5E5
		public unsafe bool bRelativeRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_bRelativeRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_bRelativeRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06007902 RID: 30978 RVA: 0x000AD3F6 File Offset: 0x000AB5F6
		// (set) Token: 0x06007903 RID: 30979 RVA: 0x000AD406 File Offset: 0x000AB606
		public unsafe bool bServerHasVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_bServerHasVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_bServerHasVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007904 RID: 30980 RVA: 0x000AD417 File Offset: 0x000AB617
		public FBasedMovementInfo()
		{
		}

		// Token: 0x06007905 RID: 30981 RVA: 0x000AD41F File Offset: 0x000AB61F
		[NullableContext(1)]
		public FBasedMovementInfo(UPrimitiveComponent MovementBase, FName BoneName, FVector_NetQuantize100 Location, FRotator Rotation, bool bServerHasBaseComponent, bool bRelativeRotation, bool bServerHasVelocity)
		{
			this.MovementBase = MovementBase;
			this.BoneName = BoneName;
			this.Location = Location;
			this.Rotation = Rotation;
			this.bServerHasBaseComponent = bServerHasBaseComponent;
			this.bRelativeRotation = bRelativeRotation;
			this.bServerHasVelocity = bServerHasVelocity;
		}

		// Token: 0x06007906 RID: 30982 RVA: 0x000AD45C File Offset: 0x000AB65C
		protected override IntPtr GetUStructPtr()
		{
			return FBasedMovementInfo.StaticStruct();
		}

		// Token: 0x06007907 RID: 30983 RVA: 0x000AD468 File Offset: 0x000AB668
		[NullableContext(2)]
		public FBasedMovementInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007908 RID: 30984 RVA: 0x000AD472 File Offset: 0x000AB672
		public FBasedMovementInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007909 RID: 30985 RVA: 0x000AD47D File Offset: 0x000AB67D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBasedMovementInfo(Pointer, false, true);
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x000AD487 File Offset: 0x000AB687
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBasedMovementInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003A18 RID: 14872
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BasedMovementInfo";

		// Token: 0x04003A19 RID: 14873
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A1A RID: 14874
		internal static int __PropertyOffset_MovementBase;

		// Token: 0x04003A1B RID: 14875
		internal static int __PropertyOffset_BoneName;

		// Token: 0x04003A1C RID: 14876
		internal static int __PropertyOffset_Location;

		// Token: 0x04003A1D RID: 14877
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04003A1E RID: 14878
		internal static int __PropertyOffset_bServerHasBaseComponent;

		// Token: 0x04003A1F RID: 14879
		internal static int __PropertyOffset_bRelativeRotation;

		// Token: 0x04003A20 RID: 14880
		internal static int __PropertyOffset_bServerHasVelocity;
	}
}
