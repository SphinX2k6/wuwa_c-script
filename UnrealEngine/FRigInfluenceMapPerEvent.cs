using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000528 RID: 1320
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigInfluenceMapPerEvent")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigInfluenceMapPerEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004529 RID: 17705 RVA: 0x00066FC6 File Offset: 0x000651C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigInfluenceMapPerEvent._ScriptStructPtr != 0) ? FRigInfluenceMapPerEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigInfluenceMapPerEvent", ref FRigInfluenceMapPerEvent._ScriptStructPtr);
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x0600452A RID: 17706 RVA: 0x00066FEC File Offset: 0x000651EC
		// (set) Token: 0x0600452B RID: 17707 RVA: 0x0006702F File Offset: 0x0006522F
		public TArray<FRigInfluenceMap> Maps
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigInfluenceMap> result;
				if ((result = this._Maps) == null)
				{
					result = (this._Maps = new TArray<FRigInfluenceMap>(base.NativePtr + (IntPtr)FRigInfluenceMapPerEvent.__PropertyOffset_Maps, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Maps.CopyAssign(value);
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x0600452C RID: 17708 RVA: 0x00067040 File Offset: 0x00065240
		// (set) Token: 0x0600452D RID: 17709 RVA: 0x00067083 File Offset: 0x00065283
		public TMap<FName, int> EventToIndex
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._EventToIndex) == null)
				{
					result = (this._EventToIndex = new TMap<FName, int>(base.NativePtr + (IntPtr)FRigInfluenceMapPerEvent.__PropertyOffset_EventToIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EventToIndex.CopyAssign(value);
			}
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x00067091 File Offset: 0x00065291
		public FRigInfluenceMapPerEvent()
		{
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x00067099 File Offset: 0x00065299
		public FRigInfluenceMapPerEvent(TArray<FRigInfluenceMap> Maps, TMap<FName, int> EventToIndex)
		{
			this.Maps = Maps;
			this.EventToIndex = EventToIndex;
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x000670AF File Offset: 0x000652AF
		protected override IntPtr GetUStructPtr()
		{
			return FRigInfluenceMapPerEvent.StaticStruct();
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x000670BB File Offset: 0x000652BB
		[NullableContext(2)]
		public FRigInfluenceMapPerEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x000670C5 File Offset: 0x000652C5
		public FRigInfluenceMapPerEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x000670D0 File Offset: 0x000652D0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigInfluenceMapPerEvent(Pointer, false, true);
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x000670DA File Offset: 0x000652DA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigInfluenceMapPerEvent(Pointer, MemoryOwner);
		}

		// Token: 0x040021B1 RID: 8625
		public const string __ObjectPath = "/Script/ControlRig.RigInfluenceMapPerEvent";

		// Token: 0x040021B2 RID: 8626
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021B3 RID: 8627
		internal static int __PropertyOffset_Maps;

		// Token: 0x040021B4 RID: 8628
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigInfluenceMap> _Maps;

		// Token: 0x040021B5 RID: 8629
		internal static int __PropertyOffset_EventToIndex;

		// Token: 0x040021B6 RID: 8630
		[Nullable(2)]
		private TMap<FName, int> _EventToIndex;
	}
}
