using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B3 RID: 1203
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/ControlRig.CachedRigElement")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCachedRigElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004006 RID: 16390 RVA: 0x00060478 File Offset: 0x0005E678
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCachedRigElement._ScriptStructPtr != 0) ? FCachedRigElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.CachedRigElement", ref FCachedRigElement._ScriptStructPtr);
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06004007 RID: 16391 RVA: 0x0006049C File Offset: 0x0005E69C
		// (set) Token: 0x06004008 RID: 16392 RVA: 0x000604DF File Offset: 0x0005E6DF
		public FRigElementKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FRigElementKey(base.NativePtr + (IntPtr)FCachedRigElement.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FCachedRigElement.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06004009 RID: 16393 RVA: 0x00060500 File Offset: 0x0005E700
		// (set) Token: 0x0600400A RID: 16394 RVA: 0x00060510 File Offset: 0x0005E710
		public unsafe ushort Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedRigElement.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedRigElement.__PropertyOffset_Index) = (short)value;
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x0600400B RID: 16395 RVA: 0x00060521 File Offset: 0x0005E721
		// (set) Token: 0x0600400C RID: 16396 RVA: 0x00060531 File Offset: 0x0005E731
		public unsafe int ContainerVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedRigElement.__PropertyOffset_ContainerVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedRigElement.__PropertyOffset_ContainerVersion) = value;
			}
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x00060542 File Offset: 0x0005E742
		public FCachedRigElement()
		{
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x0006054A File Offset: 0x0005E74A
		public FCachedRigElement(FRigElementKey Key, ushort Index, int ContainerVersion)
		{
			this.Key = Key;
			this.Index = Index;
			this.ContainerVersion = ContainerVersion;
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x00060567 File Offset: 0x0005E767
		protected override IntPtr GetUStructPtr()
		{
			return FCachedRigElement.StaticStruct();
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x00060573 File Offset: 0x0005E773
		[NullableContext(2)]
		public FCachedRigElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x0006057D File Offset: 0x0005E77D
		public FCachedRigElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x00060588 File Offset: 0x0005E788
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCachedRigElement(Pointer, false, true);
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x00060592 File Offset: 0x0005E792
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCachedRigElement(Pointer, MemoryOwner);
		}

		// Token: 0x04001E9F RID: 7839
		public const string __ObjectPath = "/Script/ControlRig.CachedRigElement";

		// Token: 0x04001EA0 RID: 7840
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001EA1 RID: 7841
		internal static int __PropertyOffset_Key;

		// Token: 0x04001EA2 RID: 7842
		[Nullable(2)]
		private FRigElementKey _Key;

		// Token: 0x04001EA3 RID: 7843
		internal static int __PropertyOffset_Index;

		// Token: 0x04001EA4 RID: 7844
		internal static int __PropertyOffset_ContainerVersion;
	}
}
