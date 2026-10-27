using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002487 RID: 9351
	[UnrealObjectPath("/Script/NavigationSystem.NavCollisionCylinder")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FNavCollisionCylinder : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022F8E RID: 143246 RVA: 0x0033B4CD File Offset: 0x003396CD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavCollisionCylinder._ScriptStructPtr != 0) ? FNavCollisionCylinder._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.NavCollisionCylinder", ref FNavCollisionCylinder._ScriptStructPtr);
		}

		// Token: 0x17008655 RID: 34389
		// (get) Token: 0x06022F8F RID: 143247 RVA: 0x0033B4F1 File Offset: 0x003396F1
		// (set) Token: 0x06022F90 RID: 143248 RVA: 0x0033B505 File Offset: 0x00339705
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavCollisionCylinder.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavCollisionCylinder.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x17008656 RID: 34390
		// (get) Token: 0x06022F91 RID: 143249 RVA: 0x0033B51A File Offset: 0x0033971A
		// (set) Token: 0x06022F92 RID: 143250 RVA: 0x0033B52A File Offset: 0x0033972A
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavCollisionCylinder.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavCollisionCylinder.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17008657 RID: 34391
		// (get) Token: 0x06022F93 RID: 143251 RVA: 0x0033B53B File Offset: 0x0033973B
		// (set) Token: 0x06022F94 RID: 143252 RVA: 0x0033B54B File Offset: 0x0033974B
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavCollisionCylinder.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavCollisionCylinder.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x06022F95 RID: 143253 RVA: 0x0033B55C File Offset: 0x0033975C
		public FNavCollisionCylinder()
		{
		}

		// Token: 0x06022F96 RID: 143254 RVA: 0x0033B564 File Offset: 0x00339764
		public FNavCollisionCylinder(FVector Offset, float Radius, float Height)
		{
			this.Offset = Offset;
			this.Radius = Radius;
			this.Height = Height;
		}

		// Token: 0x06022F97 RID: 143255 RVA: 0x0033B581 File Offset: 0x00339781
		protected override IntPtr GetUStructPtr()
		{
			return FNavCollisionCylinder.StaticStruct();
		}

		// Token: 0x06022F98 RID: 143256 RVA: 0x0033B58D File Offset: 0x0033978D
		[NullableContext(2)]
		public FNavCollisionCylinder(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022F99 RID: 143257 RVA: 0x0033B597 File Offset: 0x00339797
		public FNavCollisionCylinder(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022F9A RID: 143258 RVA: 0x0033B5A2 File Offset: 0x003397A2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavCollisionCylinder(Pointer, false, true);
		}

		// Token: 0x06022F9B RID: 143259 RVA: 0x0033B5AC File Offset: 0x003397AC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavCollisionCylinder(Pointer, MemoryOwner);
		}

		// Token: 0x04012ACF RID: 76495
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.NavCollisionCylinder";

		// Token: 0x04012AD0 RID: 76496
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012AD1 RID: 76497
		internal static int __PropertyOffset_Offset;

		// Token: 0x04012AD2 RID: 76498
		internal static int __PropertyOffset_Radius;

		// Token: 0x04012AD3 RID: 76499
		internal static int __PropertyOffset_Height;
	}
}
