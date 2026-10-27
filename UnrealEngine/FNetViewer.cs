using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EEA RID: 3818
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NetViewer")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FNetViewer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CF0C RID: 53004 RVA: 0x0012E1A3 File Offset: 0x0012C3A3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNetViewer._ScriptStructPtr != 0) ? FNetViewer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NetViewer", ref FNetViewer._ScriptStructPtr);
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x0600CF0D RID: 53005 RVA: 0x0012E1C7 File Offset: 0x0012C3C7
		// (set) Token: 0x0600CF0E RID: 53006 RVA: 0x0012E1DB File Offset: 0x0012C3DB
		public unsafe UNetConnection Connection
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNetConnection>(base.NativePtr / (IntPtr)sizeof(void*) + FNetViewer.__PropertyOffset_Connection);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNetViewer.__PropertyOffset_Connection, value);
			}
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x0600CF0F RID: 53007 RVA: 0x0012E1F0 File Offset: 0x0012C3F0
		// (set) Token: 0x0600CF10 RID: 53008 RVA: 0x0012E204 File Offset: 0x0012C404
		public unsafe AActor InViewer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FNetViewer.__PropertyOffset_InViewer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNetViewer.__PropertyOffset_InViewer, value);
			}
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x0600CF11 RID: 53009 RVA: 0x0012E219 File Offset: 0x0012C419
		// (set) Token: 0x0600CF12 RID: 53010 RVA: 0x0012E22D File Offset: 0x0012C42D
		public unsafe AActor ViewTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FNetViewer.__PropertyOffset_ViewTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNetViewer.__PropertyOffset_ViewTarget, value);
			}
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x0600CF13 RID: 53011 RVA: 0x0012E242 File Offset: 0x0012C442
		// (set) Token: 0x0600CF14 RID: 53012 RVA: 0x0012E256 File Offset: 0x0012C456
		public unsafe FVector ViewLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNetViewer.__PropertyOffset_ViewLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNetViewer.__PropertyOffset_ViewLocation) = value;
			}
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x0600CF15 RID: 53013 RVA: 0x0012E26B File Offset: 0x0012C46B
		// (set) Token: 0x0600CF16 RID: 53014 RVA: 0x0012E27F File Offset: 0x0012C47F
		public unsafe FVector ViewDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNetViewer.__PropertyOffset_ViewDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNetViewer.__PropertyOffset_ViewDir) = value;
			}
		}

		// Token: 0x0600CF17 RID: 53015 RVA: 0x0012E294 File Offset: 0x0012C494
		public FNetViewer()
		{
		}

		// Token: 0x0600CF18 RID: 53016 RVA: 0x0012E29C File Offset: 0x0012C49C
		[NullableContext(1)]
		public FNetViewer(UNetConnection Connection, AActor InViewer, AActor ViewTarget, FVector ViewLocation, FVector ViewDir)
		{
			this.Connection = Connection;
			this.InViewer = InViewer;
			this.ViewTarget = ViewTarget;
			this.ViewLocation = ViewLocation;
			this.ViewDir = ViewDir;
		}

		// Token: 0x0600CF19 RID: 53017 RVA: 0x0012E2C9 File Offset: 0x0012C4C9
		protected override IntPtr GetUStructPtr()
		{
			return FNetViewer.StaticStruct();
		}

		// Token: 0x0600CF1A RID: 53018 RVA: 0x0012E2D5 File Offset: 0x0012C4D5
		public FNetViewer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CF1B RID: 53019 RVA: 0x0012E2DF File Offset: 0x0012C4DF
		public FNetViewer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CF1C RID: 53020 RVA: 0x0012E2EA File Offset: 0x0012C4EA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNetViewer(Pointer, false, true);
		}

		// Token: 0x0600CF1D RID: 53021 RVA: 0x0012E2F4 File Offset: 0x0012C4F4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNetViewer(Pointer, MemoryOwner);
		}

		// Token: 0x04006FAC RID: 28588
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NetViewer";

		// Token: 0x04006FAD RID: 28589
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006FAE RID: 28590
		internal static int __PropertyOffset_Connection;

		// Token: 0x04006FAF RID: 28591
		internal static int __PropertyOffset_InViewer;

		// Token: 0x04006FB0 RID: 28592
		internal static int __PropertyOffset_ViewTarget;

		// Token: 0x04006FB1 RID: 28593
		internal static int __PropertyOffset_ViewLocation;

		// Token: 0x04006FB2 RID: 28594
		internal static int __PropertyOffset_ViewDir;
	}
}
