using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FBE RID: 8126
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceObject")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FLevelSequenceObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601ED60 RID: 126304 RVA: 0x002DD2FD File Offset: 0x002DB4FD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelSequenceObject._ScriptStructPtr != 0) ? FLevelSequenceObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LevelSequence.LevelSequenceObject", ref FLevelSequenceObject._ScriptStructPtr);
		}

		// Token: 0x17007AC1 RID: 31425
		// (get) Token: 0x0601ED61 RID: 126305 RVA: 0x002DD321 File Offset: 0x002DB521
		// (set) Token: 0x0601ED62 RID: 126306 RVA: 0x002DD335 File Offset: 0x002DB535
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TLazyObjectPtr<UObject> ObjectOrOwner
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSequenceObject.__PropertyOffset_ObjectOrOwner);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSequenceObject.__PropertyOffset_ObjectOrOwner) = value;
			}
		}

		// Token: 0x17007AC2 RID: 31426
		// (get) Token: 0x0601ED63 RID: 126307 RVA: 0x002DD34A File Offset: 0x002DB54A
		// (set) Token: 0x0601ED64 RID: 126308 RVA: 0x002DD35E File Offset: 0x002DB55E
		public unsafe string ComponentName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLevelSequenceObject.__PropertyOffset_ComponentName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLevelSequenceObject.__PropertyOffset_ComponentName)), value);
			}
		}

		// Token: 0x17007AC3 RID: 31427
		// (get) Token: 0x0601ED65 RID: 126309 RVA: 0x002DD373 File Offset: 0x002DB573
		// (set) Token: 0x0601ED66 RID: 126310 RVA: 0x002DD387 File Offset: 0x002DB587
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UObject> CachedComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSequenceObject.__PropertyOffset_CachedComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSequenceObject.__PropertyOffset_CachedComponent) = value;
			}
		}

		// Token: 0x0601ED67 RID: 126311 RVA: 0x002DD39C File Offset: 0x002DB59C
		public FLevelSequenceObject()
		{
		}

		// Token: 0x0601ED68 RID: 126312 RVA: 0x002DD3A4 File Offset: 0x002DB5A4
		public FLevelSequenceObject([Nullable(new byte[]
		{
			0,
			1
		})] TLazyObjectPtr<UObject> ObjectOrOwner, string ComponentName, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> CachedComponent)
		{
			this.ObjectOrOwner = ObjectOrOwner;
			this.ComponentName = ComponentName;
			this.CachedComponent = CachedComponent;
		}

		// Token: 0x0601ED69 RID: 126313 RVA: 0x002DD3C1 File Offset: 0x002DB5C1
		protected override IntPtr GetUStructPtr()
		{
			return FLevelSequenceObject.StaticStruct();
		}

		// Token: 0x0601ED6A RID: 126314 RVA: 0x002DD3CD File Offset: 0x002DB5CD
		[NullableContext(2)]
		public FLevelSequenceObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601ED6B RID: 126315 RVA: 0x002DD3D7 File Offset: 0x002DB5D7
		public FLevelSequenceObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601ED6C RID: 126316 RVA: 0x002DD3E2 File Offset: 0x002DB5E2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelSequenceObject(Pointer, false, true);
		}

		// Token: 0x0601ED6D RID: 126317 RVA: 0x002DD3EC File Offset: 0x002DB5EC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelSequenceObject(Pointer, MemoryOwner);
		}

		// Token: 0x04010A9D RID: 68253
		public const string __ObjectPath = "/Script/LevelSequence.LevelSequenceObject";

		// Token: 0x04010A9E RID: 68254
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A9F RID: 68255
		internal static int __PropertyOffset_ObjectOrOwner;

		// Token: 0x04010AA0 RID: 68256
		internal static int __PropertyOffset_ComponentName;

		// Token: 0x04010AA1 RID: 68257
		internal static int __PropertyOffset_CachedComponent;
	}
}
