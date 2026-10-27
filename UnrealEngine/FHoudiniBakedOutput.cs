using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014BA RID: 5306
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniBakedOutput")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FHoudiniBakedOutput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013340 RID: 78656 RVA: 0x001C3F46 File Offset: 0x001C2146
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniBakedOutput._ScriptStructPtr != 0) ? FHoudiniBakedOutput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniBakedOutput", ref FHoudiniBakedOutput._ScriptStructPtr);
		}

		// Token: 0x17004AAD RID: 19117
		// (get) Token: 0x06013341 RID: 78657 RVA: 0x001C3F6C File Offset: 0x001C216C
		// (set) Token: 0x06013342 RID: 78658 RVA: 0x001C3FAF File Offset: 0x001C21AF
		public TMap<FHoudiniBakedOutputObjectIdentifier, FHoudiniBakedOutputObject> BakedOutputObjects
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FHoudiniBakedOutputObjectIdentifier, FHoudiniBakedOutputObject> result;
				if ((result = this._BakedOutputObjects) == null)
				{
					result = (this._BakedOutputObjects = new TMap<FHoudiniBakedOutputObjectIdentifier, FHoudiniBakedOutputObject>(base.NativePtr + (IntPtr)FHoudiniBakedOutput.__PropertyOffset_BakedOutputObjects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BakedOutputObjects.CopyAssign(value);
			}
		}

		// Token: 0x06013343 RID: 78659 RVA: 0x001C3FBD File Offset: 0x001C21BD
		public FHoudiniBakedOutput()
		{
		}

		// Token: 0x06013344 RID: 78660 RVA: 0x001C3FC5 File Offset: 0x001C21C5
		public FHoudiniBakedOutput(TMap<FHoudiniBakedOutputObjectIdentifier, FHoudiniBakedOutputObject> BakedOutputObjects)
		{
			this.BakedOutputObjects = BakedOutputObjects;
		}

		// Token: 0x06013345 RID: 78661 RVA: 0x001C3FD4 File Offset: 0x001C21D4
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniBakedOutput.StaticStruct();
		}

		// Token: 0x06013346 RID: 78662 RVA: 0x001C3FE0 File Offset: 0x001C21E0
		[NullableContext(2)]
		public FHoudiniBakedOutput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013347 RID: 78663 RVA: 0x001C3FEA File Offset: 0x001C21EA
		public FHoudiniBakedOutput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013348 RID: 78664 RVA: 0x001C3FF5 File Offset: 0x001C21F5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniBakedOutput(Pointer, false, true);
		}

		// Token: 0x06013349 RID: 78665 RVA: 0x001C3FFF File Offset: 0x001C21FF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniBakedOutput(Pointer, MemoryOwner);
		}

		// Token: 0x0400A5F3 RID: 42483
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniBakedOutput";

		// Token: 0x0400A5F4 RID: 42484
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A5F5 RID: 42485
		internal static int __PropertyOffset_BakedOutputObjects;

		// Token: 0x0400A5F6 RID: 42486
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FHoudiniBakedOutputObjectIdentifier, FHoudiniBakedOutputObject> _BakedOutputObjects;
	}
}
