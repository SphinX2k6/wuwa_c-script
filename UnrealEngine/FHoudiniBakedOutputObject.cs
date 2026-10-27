using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014BB RID: 5307
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniBakedOutputObject")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FHoudiniBakedOutputObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601334A RID: 78666 RVA: 0x001C4008 File Offset: 0x001C2208
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniBakedOutputObject._ScriptStructPtr != 0) ? FHoudiniBakedOutputObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniBakedOutputObject", ref FHoudiniBakedOutputObject._ScriptStructPtr);
		}

		// Token: 0x17004AAE RID: 19118
		// (get) Token: 0x0601334B RID: 78667 RVA: 0x001C402C File Offset: 0x001C222C
		// (set) Token: 0x0601334C RID: 78668 RVA: 0x001C4040 File Offset: 0x001C2240
		public unsafe string Actor
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_Actor)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_Actor)), value);
			}
		}

		// Token: 0x17004AAF RID: 19119
		// (get) Token: 0x0601334D RID: 78669 RVA: 0x001C4055 File Offset: 0x001C2255
		// (set) Token: 0x0601334E RID: 78670 RVA: 0x001C4069 File Offset: 0x001C2269
		public unsafe string Blueprint
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_Blueprint)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_Blueprint)), value);
			}
		}

		// Token: 0x17004AB0 RID: 19120
		// (get) Token: 0x0601334F RID: 78671 RVA: 0x001C407E File Offset: 0x001C227E
		// (set) Token: 0x06013350 RID: 78672 RVA: 0x001C4092 File Offset: 0x001C2292
		public unsafe FName ActorBakeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_ActorBakeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_ActorBakeName) = value;
			}
		}

		// Token: 0x17004AB1 RID: 19121
		// (get) Token: 0x06013351 RID: 78673 RVA: 0x001C40A7 File Offset: 0x001C22A7
		// (set) Token: 0x06013352 RID: 78674 RVA: 0x001C40BB File Offset: 0x001C22BB
		public unsafe string BakedObject
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_BakedObject)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_BakedObject)), value);
			}
		}

		// Token: 0x17004AB2 RID: 19122
		// (get) Token: 0x06013353 RID: 78675 RVA: 0x001C40D0 File Offset: 0x001C22D0
		// (set) Token: 0x06013354 RID: 78676 RVA: 0x001C40E4 File Offset: 0x001C22E4
		public unsafe string BakedComponent
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_BakedComponent)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_BakedComponent)), value);
			}
		}

		// Token: 0x17004AB3 RID: 19123
		// (get) Token: 0x06013355 RID: 78677 RVA: 0x001C40FC File Offset: 0x001C22FC
		// (set) Token: 0x06013356 RID: 78678 RVA: 0x001C413F File Offset: 0x001C233F
		public TArray<string> InstancedActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._InstancedActors) == null)
				{
					result = (this._InstancedActors = new TArray<string>(base.NativePtr + (IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_InstancedActors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InstancedActors.CopyAssign(value);
			}
		}

		// Token: 0x17004AB4 RID: 19124
		// (get) Token: 0x06013357 RID: 78679 RVA: 0x001C4150 File Offset: 0x001C2350
		// (set) Token: 0x06013358 RID: 78680 RVA: 0x001C4193 File Offset: 0x001C2393
		public TArray<string> InstancedComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._InstancedComponents) == null)
				{
					result = (this._InstancedComponents = new TArray<string>(base.NativePtr + (IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_InstancedComponents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InstancedComponents.CopyAssign(value);
			}
		}

		// Token: 0x17004AB5 RID: 19125
		// (get) Token: 0x06013359 RID: 78681 RVA: 0x001C41A4 File Offset: 0x001C23A4
		// (set) Token: 0x0601335A RID: 78682 RVA: 0x001C41E7 File Offset: 0x001C23E7
		public TMap<FName, string> LandscapeLayers
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, string> result;
				if ((result = this._LandscapeLayers) == null)
				{
					result = (this._LandscapeLayers = new TMap<FName, string>(base.NativePtr + (IntPtr)FHoudiniBakedOutputObject.__PropertyOffset_LandscapeLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LandscapeLayers.CopyAssign(value);
			}
		}

		// Token: 0x0601335B RID: 78683 RVA: 0x001C41F5 File Offset: 0x001C23F5
		public FHoudiniBakedOutputObject()
		{
		}

		// Token: 0x0601335C RID: 78684 RVA: 0x001C4200 File Offset: 0x001C2400
		public FHoudiniBakedOutputObject(string Actor, string Blueprint, FName ActorBakeName, string BakedObject, string BakedComponent, TArray<string> InstancedActors, TArray<string> InstancedComponents, TMap<FName, string> LandscapeLayers)
		{
			this.Actor = Actor;
			this.Blueprint = Blueprint;
			this.ActorBakeName = ActorBakeName;
			this.BakedObject = BakedObject;
			this.BakedComponent = BakedComponent;
			this.InstancedActors = InstancedActors;
			this.InstancedComponents = InstancedComponents;
			this.LandscapeLayers = LandscapeLayers;
		}

		// Token: 0x0601335D RID: 78685 RVA: 0x001C4250 File Offset: 0x001C2450
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniBakedOutputObject.StaticStruct();
		}

		// Token: 0x0601335E RID: 78686 RVA: 0x001C425C File Offset: 0x001C245C
		[NullableContext(2)]
		public FHoudiniBakedOutputObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601335F RID: 78687 RVA: 0x001C4266 File Offset: 0x001C2466
		public FHoudiniBakedOutputObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013360 RID: 78688 RVA: 0x001C4271 File Offset: 0x001C2471
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniBakedOutputObject(Pointer, false, true);
		}

		// Token: 0x06013361 RID: 78689 RVA: 0x001C427B File Offset: 0x001C247B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniBakedOutputObject(Pointer, MemoryOwner);
		}

		// Token: 0x0400A5F7 RID: 42487
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniBakedOutputObject";

		// Token: 0x0400A5F8 RID: 42488
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A5F9 RID: 42489
		internal static int __PropertyOffset_Actor;

		// Token: 0x0400A5FA RID: 42490
		internal static int __PropertyOffset_Blueprint;

		// Token: 0x0400A5FB RID: 42491
		internal static int __PropertyOffset_ActorBakeName;

		// Token: 0x0400A5FC RID: 42492
		internal static int __PropertyOffset_BakedObject;

		// Token: 0x0400A5FD RID: 42493
		internal static int __PropertyOffset_BakedComponent;

		// Token: 0x0400A5FE RID: 42494
		internal static int __PropertyOffset_InstancedActors;

		// Token: 0x0400A5FF RID: 42495
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _InstancedActors;

		// Token: 0x0400A600 RID: 42496
		internal static int __PropertyOffset_InstancedComponents;

		// Token: 0x0400A601 RID: 42497
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _InstancedComponents;

		// Token: 0x0400A602 RID: 42498
		internal static int __PropertyOffset_LandscapeLayers;

		// Token: 0x0400A603 RID: 42499
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, string> _LandscapeLayers;
	}
}
