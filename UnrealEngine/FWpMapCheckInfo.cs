using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001293 RID: 4755
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WpMapCheckInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FWpMapCheckInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601173F RID: 71487 RVA: 0x00199F99 File Offset: 0x00198199
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWpMapCheckInfo._ScriptStructPtr != 0) ? FWpMapCheckInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WpMapCheckInfo", ref FWpMapCheckInfo._ScriptStructPtr);
		}

		// Token: 0x17004416 RID: 17430
		// (get) Token: 0x06011740 RID: 71488 RVA: 0x00199FBD File Offset: 0x001981BD
		// (set) Token: 0x06011741 RID: 71489 RVA: 0x00199FD1 File Offset: 0x001981D1
		public unsafe string Message
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FWpMapCheckInfo.__PropertyOffset_Message)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FWpMapCheckInfo.__PropertyOffset_Message)), value);
			}
		}

		// Token: 0x17004417 RID: 17431
		// (get) Token: 0x06011742 RID: 71490 RVA: 0x00199FE6 File Offset: 0x001981E6
		// (set) Token: 0x06011743 RID: 71491 RVA: 0x00199FFA File Offset: 0x001981FA
		public unsafe FName ActorOutlinePath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWpMapCheckInfo.__PropertyOffset_ActorOutlinePath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWpMapCheckInfo.__PropertyOffset_ActorOutlinePath) = value;
			}
		}

		// Token: 0x17004418 RID: 17432
		// (get) Token: 0x06011744 RID: 71492 RVA: 0x0019A00F File Offset: 0x0019820F
		// (set) Token: 0x06011745 RID: 71493 RVA: 0x0019A023 File Offset: 0x00198223
		public unsafe FName ActorPackage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWpMapCheckInfo.__PropertyOffset_ActorPackage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWpMapCheckInfo.__PropertyOffset_ActorPackage) = value;
			}
		}

		// Token: 0x17004419 RID: 17433
		// (get) Token: 0x06011746 RID: 71494 RVA: 0x0019A038 File Offset: 0x00198238
		// (set) Token: 0x06011747 RID: 71495 RVA: 0x0019A07B File Offset: 0x0019827B
		public TArray<FName> ReferenceActorPackages
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ReferenceActorPackages) == null)
				{
					result = (this._ReferenceActorPackages = new TArray<FName>(base.NativePtr + (IntPtr)FWpMapCheckInfo.__PropertyOffset_ReferenceActorPackages, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReferenceActorPackages.CopyAssign(value);
			}
		}

		// Token: 0x06011748 RID: 71496 RVA: 0x0019A089 File Offset: 0x00198289
		public FWpMapCheckInfo()
		{
		}

		// Token: 0x06011749 RID: 71497 RVA: 0x0019A091 File Offset: 0x00198291
		public FWpMapCheckInfo(string Message, FName ActorOutlinePath, FName ActorPackage, TArray<FName> ReferenceActorPackages)
		{
			this.Message = Message;
			this.ActorOutlinePath = ActorOutlinePath;
			this.ActorPackage = ActorPackage;
			this.ReferenceActorPackages = ReferenceActorPackages;
		}

		// Token: 0x0601174A RID: 71498 RVA: 0x0019A0B6 File Offset: 0x001982B6
		protected override IntPtr GetUStructPtr()
		{
			return FWpMapCheckInfo.StaticStruct();
		}

		// Token: 0x0601174B RID: 71499 RVA: 0x0019A0C2 File Offset: 0x001982C2
		[NullableContext(2)]
		public FWpMapCheckInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601174C RID: 71500 RVA: 0x0019A0CC File Offset: 0x001982CC
		public FWpMapCheckInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601174D RID: 71501 RVA: 0x0019A0D7 File Offset: 0x001982D7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWpMapCheckInfo(Pointer, false, true);
		}

		// Token: 0x0601174E RID: 71502 RVA: 0x0019A0E1 File Offset: 0x001982E1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWpMapCheckInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400957D RID: 38269
		public const string __ObjectPath = "/Script/Engine.WpMapCheckInfo";

		// Token: 0x0400957E RID: 38270
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400957F RID: 38271
		internal static int __PropertyOffset_Message;

		// Token: 0x04009580 RID: 38272
		internal static int __PropertyOffset_ActorOutlinePath;

		// Token: 0x04009581 RID: 38273
		internal static int __PropertyOffset_ActorPackage;

		// Token: 0x04009582 RID: 38274
		internal static int __PropertyOffset_ReferenceActorPackages;

		// Token: 0x04009583 RID: 38275
		[Nullable(2)]
		private TArray<FName> _ReferenceActorPackages;
	}
}
