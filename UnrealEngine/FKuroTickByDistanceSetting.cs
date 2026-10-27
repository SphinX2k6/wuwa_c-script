using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200251C RID: 9500
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.KuroTickByDistanceSetting")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FKuroTickByDistanceSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060234BF RID: 144575 RVA: 0x0034343C File Offset: 0x0034163C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroTickByDistanceSetting._ScriptStructPtr != 0) ? FKuroTickByDistanceSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.KuroTickByDistanceSetting", ref FKuroTickByDistanceSetting._ScriptStructPtr);
		}

		// Token: 0x170087C6 RID: 34758
		// (get) Token: 0x060234C0 RID: 144576 RVA: 0x00343460 File Offset: 0x00341660
		// (set) Token: 0x060234C1 RID: 144577 RVA: 0x003434A3 File Offset: 0x003416A3
		public FNiagaraPlatformSet Platforms
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraPlatformSet result;
				if ((result = this._Platforms) == null)
				{
					result = (this._Platforms = new FNiagaraPlatformSet(base.NativePtr + (IntPtr)FKuroTickByDistanceSetting.__PropertyOffset_Platforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraPlatformSet.StaticStruct(), base.NativePtr + (IntPtr)FKuroTickByDistanceSetting.__PropertyOffset_Platforms, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170087C7 RID: 34759
		// (get) Token: 0x060234C2 RID: 144578 RVA: 0x003434C4 File Offset: 0x003416C4
		// (set) Token: 0x060234C3 RID: 144579 RVA: 0x003434D4 File Offset: 0x003416D4
		public unsafe float MaxTickDeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTickByDistanceSetting.__PropertyOffset_MaxTickDeltaSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTickByDistanceSetting.__PropertyOffset_MaxTickDeltaSeconds) = value;
			}
		}

		// Token: 0x170087C8 RID: 34760
		// (get) Token: 0x060234C4 RID: 144580 RVA: 0x003434E8 File Offset: 0x003416E8
		// (set) Token: 0x060234C5 RID: 144581 RVA: 0x0034352B File Offset: 0x0034172B
		public TArray<FKuroTickByDistance> TickByDistanceArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroTickByDistance> result;
				if ((result = this._TickByDistanceArray) == null)
				{
					result = (this._TickByDistanceArray = new TArray<FKuroTickByDistance>(base.NativePtr + (IntPtr)FKuroTickByDistanceSetting.__PropertyOffset_TickByDistanceArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TickByDistanceArray.CopyAssign(value);
			}
		}

		// Token: 0x060234C6 RID: 144582 RVA: 0x00343539 File Offset: 0x00341739
		public FKuroTickByDistanceSetting()
		{
		}

		// Token: 0x060234C7 RID: 144583 RVA: 0x00343541 File Offset: 0x00341741
		public FKuroTickByDistanceSetting(FNiagaraPlatformSet Platforms, float MaxTickDeltaSeconds, TArray<FKuroTickByDistance> TickByDistanceArray)
		{
			this.Platforms = Platforms;
			this.MaxTickDeltaSeconds = MaxTickDeltaSeconds;
			this.TickByDistanceArray = TickByDistanceArray;
		}

		// Token: 0x060234C8 RID: 144584 RVA: 0x0034355E File Offset: 0x0034175E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroTickByDistanceSetting.StaticStruct();
		}

		// Token: 0x060234C9 RID: 144585 RVA: 0x0034356A File Offset: 0x0034176A
		[NullableContext(2)]
		public FKuroTickByDistanceSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060234CA RID: 144586 RVA: 0x00343574 File Offset: 0x00341774
		public FKuroTickByDistanceSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060234CB RID: 144587 RVA: 0x0034357F File Offset: 0x0034177F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroTickByDistanceSetting(Pointer, false, true);
		}

		// Token: 0x060234CC RID: 144588 RVA: 0x00343589 File Offset: 0x00341789
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroTickByDistanceSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04012F2E RID: 77614
		public const string __ObjectPath = "/Script/Niagara.KuroTickByDistanceSetting";

		// Token: 0x04012F2F RID: 77615
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012F30 RID: 77616
		internal static int __PropertyOffset_Platforms;

		// Token: 0x04012F31 RID: 77617
		[Nullable(2)]
		private FNiagaraPlatformSet _Platforms;

		// Token: 0x04012F32 RID: 77618
		internal static int __PropertyOffset_MaxTickDeltaSeconds;

		// Token: 0x04012F33 RID: 77619
		internal static int __PropertyOffset_TickByDistanceArray;

		// Token: 0x04012F34 RID: 77620
		[Nullable(2)]
		private TArray<FKuroTickByDistance> _TickByDistanceArray;
	}
}
