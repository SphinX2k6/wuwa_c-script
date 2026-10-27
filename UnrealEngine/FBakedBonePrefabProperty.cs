using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000888 RID: 2184
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBonePrefabProperty")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FBakedBonePrefabProperty : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007774 RID: 30580 RVA: 0x000AB1B5 File Offset: 0x000A93B5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBonePrefabProperty._ScriptStructPtr != 0) ? FBakedBonePrefabProperty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBonePrefabProperty", ref FBakedBonePrefabProperty._ScriptStructPtr);
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06007775 RID: 30581 RVA: 0x000AB1D9 File Offset: 0x000A93D9
		// (set) Token: 0x06007776 RID: 30582 RVA: 0x000AB1ED File Offset: 0x000A93ED
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBakedBonePrefabProperty.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBakedBonePrefabProperty.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06007777 RID: 30583 RVA: 0x000AB202 File Offset: 0x000A9402
		// (set) Token: 0x06007778 RID: 30584 RVA: 0x000AB216 File Offset: 0x000A9416
		public unsafe string Value
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBakedBonePrefabProperty.__PropertyOffset_Value)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBakedBonePrefabProperty.__PropertyOffset_Value)), value);
			}
		}

		// Token: 0x06007779 RID: 30585 RVA: 0x000AB22B File Offset: 0x000A942B
		public FBakedBonePrefabProperty()
		{
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x000AB233 File Offset: 0x000A9433
		public FBakedBonePrefabProperty(string Name, string Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0600777B RID: 30587 RVA: 0x000AB249 File Offset: 0x000A9449
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBonePrefabProperty.StaticStruct();
		}

		// Token: 0x0600777C RID: 30588 RVA: 0x000AB255 File Offset: 0x000A9455
		[NullableContext(2)]
		public FBakedBonePrefabProperty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600777D RID: 30589 RVA: 0x000AB25F File Offset: 0x000A945F
		public FBakedBonePrefabProperty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600777E RID: 30590 RVA: 0x000AB26A File Offset: 0x000A946A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBonePrefabProperty(Pointer, false, true);
		}

		// Token: 0x0600777F RID: 30591 RVA: 0x000AB274 File Offset: 0x000A9474
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBonePrefabProperty(Pointer, MemoryOwner);
		}

		// Token: 0x0400395D RID: 14685
		public const string __ObjectPath = "/Script/Engine.BakedBonePrefabProperty";

		// Token: 0x0400395E RID: 14686
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400395F RID: 14687
		internal static int __PropertyOffset_Name;

		// Token: 0x04003960 RID: 14688
		internal static int __PropertyOffset_Value;
	}
}
