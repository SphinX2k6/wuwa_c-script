using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200294E RID: 10574
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.DragDropOperation")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UDragDropOperation : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027265 RID: 160357 RVA: 0x003BB0D5 File Offset: 0x003B92D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDragDropOperation._ClassPtr;
		}

		// Token: 0x06027266 RID: 160358 RVA: 0x003BB0E4 File Offset: 0x003B92E4
		public UDragDropOperation() : this(BuiltinUtils.AllocNativeUObject(UDragDropOperation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027267 RID: 160359 RVA: 0x003BB10C File Offset: 0x003B930C
		[NullableContext(1)]
		public UDragDropOperation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDragDropOperation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009694 RID: 38548
		// (get) Token: 0x06027268 RID: 160360 RVA: 0x003BB13F File Offset: 0x003B933F
		// (set) Token: 0x06027269 RID: 160361 RVA: 0x003BB153 File Offset: 0x003B9353
		[Nullable(1)]
		public unsafe string Tag
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UDragDropOperation.__PropertyOffset_Tag)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UDragDropOperation.__PropertyOffset_Tag)), value);
			}
		}

		// Token: 0x17009695 RID: 38549
		// (get) Token: 0x0602726A RID: 160362 RVA: 0x003BB168 File Offset: 0x003B9368
		// (set) Token: 0x0602726B RID: 160363 RVA: 0x003BB17C File Offset: 0x003B937C
		public unsafe UObject Payload
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UDragDropOperation.__PropertyOffset_Payload);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDragDropOperation.__PropertyOffset_Payload, value);
			}
		}

		// Token: 0x17009696 RID: 38550
		// (get) Token: 0x0602726C RID: 160364 RVA: 0x003BB191 File Offset: 0x003B9391
		// (set) Token: 0x0602726D RID: 160365 RVA: 0x003BB1A5 File Offset: 0x003B93A5
		public unsafe UWidget DefaultDragVisual
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidget>(base.NativePtr / (IntPtr)sizeof(void*) + UDragDropOperation.__PropertyOffset_DefaultDragVisual);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDragDropOperation.__PropertyOffset_DefaultDragVisual, value);
			}
		}

		// Token: 0x17009697 RID: 38551
		// (get) Token: 0x0602726E RID: 160366 RVA: 0x003BB1BA File Offset: 0x003B93BA
		// (set) Token: 0x0602726F RID: 160367 RVA: 0x003BB1CA File Offset: 0x003B93CA
		public unsafe EDragPivot Pivot
		{
			get
			{
				return (EDragPivot)(*(base.NativePtr + (IntPtr)UDragDropOperation.__PropertyOffset_Pivot));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDragDropOperation.__PropertyOffset_Pivot) = (byte)value;
			}
		}

		// Token: 0x17009698 RID: 38552
		// (get) Token: 0x06027270 RID: 160368 RVA: 0x003BB1DB File Offset: 0x003B93DB
		// (set) Token: 0x06027271 RID: 160369 RVA: 0x003BB1EF File Offset: 0x003B93EF
		public unsafe FVector2D Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDragDropOperation.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDragDropOperation.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x17009699 RID: 38553
		// (get) Token: 0x06027272 RID: 160370 RVA: 0x003BB204 File Offset: 0x003B9404
		// (set) Token: 0x06027273 RID: 160371 RVA: 0x003BB23D File Offset: 0x003B943D
		[Nullable(1)]
		public FOnDragDropMulticast OnDrop
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnDragDropMulticast result;
				if ((result = this._OnDrop) == null)
				{
					result = (this._OnDrop = new FOnDragDropMulticast(base.NativePtr + (IntPtr)UDragDropOperation.__PropertyOffset_OnDrop, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UDragDropOperation.__PropertyOffset_OnDrop, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700969A RID: 38554
		// (get) Token: 0x06027274 RID: 160372 RVA: 0x003BB260 File Offset: 0x003B9460
		// (set) Token: 0x06027275 RID: 160373 RVA: 0x003BB299 File Offset: 0x003B9499
		[Nullable(1)]
		public FOnDragDropMulticast OnDragCancelled
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnDragDropMulticast result;
				if ((result = this._OnDragCancelled) == null)
				{
					result = (this._OnDragCancelled = new FOnDragDropMulticast(base.NativePtr + (IntPtr)UDragDropOperation.__PropertyOffset_OnDragCancelled, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UDragDropOperation.__PropertyOffset_OnDragCancelled, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700969B RID: 38555
		// (get) Token: 0x06027276 RID: 160374 RVA: 0x003BB2BC File Offset: 0x003B94BC
		// (set) Token: 0x06027277 RID: 160375 RVA: 0x003BB2F5 File Offset: 0x003B94F5
		[Nullable(1)]
		public FOnDragDropMulticast OnDragged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnDragDropMulticast result;
				if ((result = this._OnDragged) == null)
				{
					result = (this._OnDragged = new FOnDragDropMulticast(base.NativePtr + (IntPtr)UDragDropOperation.__PropertyOffset_OnDragged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UDragDropOperation.__PropertyOffset_OnDragged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06027278 RID: 160376 RVA: 0x003BB316 File Offset: 0x003B9516
		public virtual void Drop(in FPointerEvent PointerEvent)
		{
			UDragDropOperation.__Drop_Internal(base.NativePtr, (PointerEvent ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x06027279 RID: 160377 RVA: 0x003BB333 File Offset: 0x003B9533
		protected virtual void Drop_Implementation(in FPointerEvent PointerEvent)
		{
			UDragDropOperation.__Drop_Implementation_Internal(base.NativePtr, (PointerEvent ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0602727A RID: 160378 RVA: 0x003BB350 File Offset: 0x003B9550
		public virtual void Dragged(in FPointerEvent PointerEvent)
		{
			UDragDropOperation.__Dragged_Internal(base.NativePtr, (PointerEvent ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0602727B RID: 160379 RVA: 0x003BB36D File Offset: 0x003B956D
		protected virtual void Dragged_Implementation(in FPointerEvent PointerEvent)
		{
			UDragDropOperation.__Dragged_Implementation_Internal(base.NativePtr, (PointerEvent ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0602727C RID: 160380 RVA: 0x003BB38A File Offset: 0x003B958A
		public virtual void DragCancelled(in FPointerEvent PointerEvent)
		{
			UDragDropOperation.__DragCancelled_Internal(base.NativePtr, (PointerEvent ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0602727D RID: 160381 RVA: 0x003BB3A7 File Offset: 0x003B95A7
		protected virtual void DragCancelled_Implementation(in FPointerEvent PointerEvent)
		{
			UDragDropOperation.__DragCancelled_Implementation_Internal(base.NativePtr, (PointerEvent ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0602727E RID: 160382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Drop_Internal(IntPtr @this, IntPtr PointerEvent);

		// Token: 0x0602727F RID: 160383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Drop_Implementation_Internal(IntPtr @this, IntPtr PointerEvent);

		// Token: 0x06027280 RID: 160384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Dragged_Internal(IntPtr @this, IntPtr PointerEvent);

		// Token: 0x06027281 RID: 160385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Dragged_Implementation_Internal(IntPtr @this, IntPtr PointerEvent);

		// Token: 0x06027282 RID: 160386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DragCancelled_Internal(IntPtr @this, IntPtr PointerEvent);

		// Token: 0x06027283 RID: 160387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DragCancelled_Implementation_Internal(IntPtr @this, IntPtr PointerEvent);

		// Token: 0x06027284 RID: 160388 RVA: 0x003BB3C4 File Offset: 0x003B95C4
		static UDragDropOperation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.DragDropOperation");
		}

		// Token: 0x06027285 RID: 160389 RVA: 0x003BB3D2 File Offset: 0x003B95D2
		protected UDragDropOperation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157F5 RID: 88053
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.DragDropOperation";

		// Token: 0x040157F6 RID: 88054
		private static IntPtr _ClassPtr;

		// Token: 0x040157F7 RID: 88055
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040157F8 RID: 88056
		internal static int __PropertyOffset_Tag;

		// Token: 0x040157F9 RID: 88057
		internal static int __PropertyOffset_Payload;

		// Token: 0x040157FA RID: 88058
		internal static int __PropertyOffset_DefaultDragVisual;

		// Token: 0x040157FB RID: 88059
		internal static int __PropertyOffset_Pivot;

		// Token: 0x040157FC RID: 88060
		internal static int __PropertyOffset_Offset;

		// Token: 0x040157FD RID: 88061
		internal static int __PropertyOffset_OnDrop;

		// Token: 0x040157FE RID: 88062
		private FOnDragDropMulticast _OnDrop;

		// Token: 0x040157FF RID: 88063
		internal static int __PropertyOffset_OnDragCancelled;

		// Token: 0x04015800 RID: 88064
		private FOnDragDropMulticast _OnDragCancelled;

		// Token: 0x04015801 RID: 88065
		internal static int __PropertyOffset_OnDragged;

		// Token: 0x04015802 RID: 88066
		private FOnDragDropMulticast _OnDragged;

		// Token: 0x02003B6A RID: 15210
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __Drop_FunctionParams
		{
			// Token: 0x04017D42 RID: 97602
			[FieldOffset(0)]
			public byte PointerEvent;
		}

		// Token: 0x02003B6B RID: 15211
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __Dragged_FunctionParams
		{
			// Token: 0x04017D43 RID: 97603
			[FieldOffset(0)]
			public byte PointerEvent;
		}

		// Token: 0x02003B6C RID: 15212
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __DragCancelled_FunctionParams
		{
			// Token: 0x04017D44 RID: 97604
			[FieldOffset(0)]
			public byte PointerEvent;
		}
	}
}
